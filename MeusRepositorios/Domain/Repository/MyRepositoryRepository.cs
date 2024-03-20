using MeusRepositorios.Domain.Context;
using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Repository
{
    public class MyRepositoryRepository : IDisposable, IMyRepository
    {
        AppDbContext _context = new AppDbContext();

        public IQueryable<MyRepository> Get()
        {
            return _context.MyRepository.AsQueryable();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool SaveOrUpdateMyRepository(MyRepository myRepository, Favorite favorite)
        {
            bool result = false;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var existMyRepository = _context.MyRepository.FirstOrDefault(x => x.Id == myRepository.Id);

                    if (existMyRepository != null)
                    {
                        _context.Entry(existMyRepository).CurrentValues.SetValues(myRepository);
                    }
                    else
                    {
                        _context.MyRepository.Add(myRepository);
                    }

                    if (!myRepository.isFavorite)
                    {
                        var existingFavorite = _context.Favorite.FirstOrDefault(x => x.MyRepositoryId == myRepository.Id);
                        if (existingFavorite != null)
                        {
                            _context.Favorite.Remove(existingFavorite);
                        }
                    }
                    else
                    {
                        var existingFavorite = _context.Favorite.FirstOrDefault(x => x.MyRepositoryId == myRepository.Id);
                        if (existingFavorite != null)
                        {
                            _context.Entry(existingFavorite).CurrentValues.SetValues(favorite);
                        }
                        else
                        {
                            favorite.MyRepositoryId = myRepository.Id;
                            _context.Favorite.Add(favorite);
                        }
                    }

                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    result = false;
                }
            }
            return result;
        }


        public bool DeleteAll()
        {
            bool result = false;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var allRecordsMyRepository = _context.MyRepository.ToList();
                    var allRecordsFavorite = _context.Favorite.ToList();

                    _context.MyRepository.RemoveRange(allRecordsMyRepository);
                    _context.Favorite.RemoveRange(allRecordsFavorite);

                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    result = false;
                }
            }
            return result;
        }

        public MyRepository GetById(int idRepository)
        {
            return _context.MyRepository.Where(x => x.Id == idRepository).FirstOrDefault();
        }
    }
}
