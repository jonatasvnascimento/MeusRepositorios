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
                    var existMyRepository = _context.MyRepository.Where(x => x.Id == myRepository.Id).FirstOrDefault();
                    var existFavorite = _context.Favorite.Where(x => x.MyRepositortId == favorite.MyRepositortId).FirstOrDefault();

                    if (existMyRepository != null)
                        _context.MyRepository.Entry(existMyRepository).CurrentValues.SetValues(myRepository);
                    else
                        _context.MyRepository.Add(myRepository);

                    _context.SaveChanges();

                    if (existFavorite != null)
                    {
                        if (!myRepository.isFavorite)
                        {
                            _context.Favorite.Remove(favorite);
                        }
                    }
                    else
                    {
                        if (myRepository.isFavorite)
                        {
                            favorite.MyRepositortId = myRepository.Id;
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
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    result = false;
                }
            }
            return result;
        }
    }
}
