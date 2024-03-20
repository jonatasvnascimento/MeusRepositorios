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

        public bool SaveOrUpdateMyRepository(MyRepository myRepository)
        {
            bool result = false;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var exist = _context.MyRepository.Where(x => x.Id == myRepository.Id).FirstOrDefault();

                    if (exist != null)
                    {
                        _context.MyRepository.Entry(exist).CurrentValues.SetValues(myRepository);
                    }
                    else
                    {
                        _context.MyRepository.Add(myRepository);
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
                    var allRecords = _context.MyRepository.ToList();

                    _context.MyRepository.RemoveRange(allRecords);

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
