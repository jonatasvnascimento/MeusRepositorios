using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusRepositorios.Domain.Model
{
    public class MyRepository
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Linguagem { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string DonoRepositorio { get; set; }

        [NotMapped]
        public bool isFavorite { get; set; }
    }
}
