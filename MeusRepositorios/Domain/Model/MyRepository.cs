using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Model
{
    public class Favorite
    {
        public int Id { get; set; }
        public required int MyRepositortId { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string Linguagem { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string DonoRepositorio { get; set; }
    }
}
