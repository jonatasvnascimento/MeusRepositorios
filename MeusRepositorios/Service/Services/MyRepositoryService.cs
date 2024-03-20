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

        public bool DeleteAll()
        {
            return _myRepositoryRepository.DeleteAll();
        }

        public IQueryable<MyRepository> Get()
        {
            return _myRepositoryRepository.Get();
        }

        public bool SaveOrUpdateMyRepository(MyRepository myRepository)
        {

        Favorite favoriteOBJ = new Favorite()
            {
                MyRepositortId = myRepository.Id,
                Nome = myRepository.Nome,
                Descricao = myRepository.Descricao,
                Linguagem = myRepository.Linguagem,
                DataAtualizacao = myRepository.DataAtualizacao,
                DonoRepositorio = myRepository.DonoRepositorio
            };

            return _myRepositoryRepository.SaveOrUpdateMyRepository(myRepository, favoriteOBJ);
        }
    }
}
