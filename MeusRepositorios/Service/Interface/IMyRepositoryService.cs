using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Service.Interface
{
    public interface IMyRepositoryService
    {
        IQueryable<MyRepository> Get();
        MyRepository GetById(int idRepository);
        bool SaveOrUpdateMyRepository(MyRepository myRepository); 
        bool DeleteAll();
        bool DeleteById(int idRepository);
    }
}
