using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
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
        private readonly IMyRepository _myRepository;
        public IQueryable<MyRepository> Get()
        {
            return _myRepository.Get();
        }
    }
}
