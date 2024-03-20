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
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _favoriteRepository;
        public IQueryable<Favorite> Get()
        {
            return _favoriteRepository.Get();
        }

        public bool SaveOrUpdateFavorite(Favorite myRepository)
        {
            return _favoriteRepository.SaveOrUpdateFavorite(myRepository);
        }
    }
}
