using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Interface
{
    public interface IRepository<T> : IUnitOfWork
    {
        IQueryable<T> Get();
        void Update(T entity);
        void Delete(T entity);
    }
}
