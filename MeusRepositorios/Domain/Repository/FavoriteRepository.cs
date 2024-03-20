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
    public class FavoriteRepository : IDisposable, IFavoriteRepository
    {
        AppDbContext _context = new AppDbContext();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryable<Favorite> Get()
        {
            return _context.Favorite.AsQueryable();
        }

        public bool SaveOrUpdateFavorite(Favorite favorite)
        {
            bool result = false;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var exist = _context.Favorite.Where(x => x.Id == favorite.Id).FirstOrDefault();

                    if (exist != null)
                    {
                        _context.Favorite.Entry(exist).CurrentValues.SetValues(favorite);
                    }
                    else
                    {
                        _context.Favorite.Add(favorite);
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
    }
}
