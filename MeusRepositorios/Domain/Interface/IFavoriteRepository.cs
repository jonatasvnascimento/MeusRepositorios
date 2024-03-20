using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Interface
{
    public interface IFavoriteRepository
    {
        IQueryable<Favorite> Get();
        bool SaveOrUpdateFavorite(Favorite myRepository);
    }
}
