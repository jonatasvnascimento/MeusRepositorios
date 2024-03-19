using MeusRepositorios.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<MyRepository> MyRepositories{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyDatabase;Integrated Security=True;");
        }
    }

}
