using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
using MeusRepositorios.Domain.Repository;
using MeusRepositorios.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Service.Services
{
    public class MyRepositoryService : IMyRepositoryService
    {
        private readonly MyRepositoryRepository _myRepositoryRepository = new MyRepositoryRepository();

        public IQueryable<MyRepository> Get()
        {
            return _myRepositoryRepository.Get();
        }
    }
}
