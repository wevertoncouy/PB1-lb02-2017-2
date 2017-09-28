using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinema.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public decimal Duracao { get; set; }
        public Sessao Sessao { get; set; }
        public List<Ator> Autores { get; set; }

    }
}