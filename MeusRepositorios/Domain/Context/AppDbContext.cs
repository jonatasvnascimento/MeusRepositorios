using MeusRepositorios.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Context
{
    public class AppDbContext : DbContext
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string DefaultConnection = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(DefaultConnection);
        }

        public DbSet<MyRepository> MyRepository { get; set; }
        public DbSet<Favorite> Favorite { get; set; }


    }

}
