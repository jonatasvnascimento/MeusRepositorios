using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Interface
{
    public interface IMyRepository
    {
        IQueryable<MyRepository> Get();
        MyRepository GetById(int idRepository);
        bool SaveOrUpdateMyRepository(MyRepository myRepository, Favorite favorite);
        bool DeleteAll();
        bool DeleteById(int idRepository);

    }
}
