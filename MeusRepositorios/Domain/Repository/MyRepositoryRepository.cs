using MeusRepositorios.Domain.Context;
using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
using Microsoft.EntityFrameworkCore;
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
            return _context.MyRepository.AsQueryable().AsNoTracking();
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
                    var existingMyRepository = _context.MyRepository.FirstOrDefault(x => x.Id == myRepository.Id);

                    if (existingMyRepository != null)
                    {
                        _context.Entry(existingMyRepository).CurrentValues.SetValues(myRepository);
                    }
                    else
                    {
                        _context.MyRepository.Add(myRepository);
                    }

                    _context.SaveChanges();

                    var existingFavorite = _context.Favorite.FirstOrDefault(x => x.MyRepositoryId == myRepository.Id);

                    if (!myRepository.isFavorite)
                    {
                        if (existingFavorite != null)
                        {
                            _context.Favorite.Remove(existingFavorite);
                        }
                    }
                    else
                    {
                        if (existingFavorite == null)
                        {
                            favorite.MyRepositoryId = myRepository.Id;
                            _context.Favorite.Add(favorite);
                        }
                        else
                        {
                            _context.Entry(existingFavorite).CurrentValues.SetValues(favorite);
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

        public bool DeleteById(int idRepository)
        {
            bool result = false;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var allRecordsMyRepository = _context.MyRepository.Where(x => x.Id == idRepository).FirstOrDefault();
                    var allRecordsFavorite = _context.Favorite.Where(x => x.MyRepositoryId == idRepository).FirstOrDefault();

                    if (allRecordsMyRepository != null)
                    {
                        _context.MyRepository.Remove(allRecordsMyRepository);
                    }

                    if (allRecordsFavorite != null)
                    {
                        _context.Favorite.Remove(allRecordsFavorite);
                    }

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
    }
}
