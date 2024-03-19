using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Model
{
    public class MyRepository
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Descricao { get; set; }
        public required string Linquagem { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DonoRepositorio { get; set; }
    }
}
