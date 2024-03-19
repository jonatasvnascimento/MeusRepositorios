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
    public class MyRepositoryRepository : IDisposable
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
    }
}
