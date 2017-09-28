using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinema.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DateHoraFim { get; set; }
        public decimal ValorInteiro { get; set; }
        public decimal ValorMeia { get; set; }
        public bool Encerrada { get; set; }

        public List<Filme> Filmes { get; set; }
        public List<Ingresso> Ingressos { get; set; }

        public Sala Sala { get; set; }

    }
}