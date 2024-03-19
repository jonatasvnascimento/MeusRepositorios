using MeusRepositorios.Domain.Context;
using MeusRepositorios.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected AppDbContext _context;

        public Repository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }

        public async Task<bool> CommitAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
