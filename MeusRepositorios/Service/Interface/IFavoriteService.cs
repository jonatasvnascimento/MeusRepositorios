using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Service.Interface
{
    public interface IFavoriteService
    {
        IQueryable<Favorite> Get();
        bool SaveOrUpdateFavorite(Favorite myRepository);
    }
}
