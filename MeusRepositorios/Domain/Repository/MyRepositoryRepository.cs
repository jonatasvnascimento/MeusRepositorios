using MeusRepositorios.Domain.Context;
using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Repository
{
    public class MyRepositoryRepository : Repository<MyRepository>, IMyRepository
    {
        public MyRepositoryRepository(AppDbContext contexto) : base(contexto)
        {
        }
    }
}
