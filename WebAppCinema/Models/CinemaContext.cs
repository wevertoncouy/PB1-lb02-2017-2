using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppCinema.Models
{
    public class CinemaContext:DbContext
    {
        public CinemaContext(): base("CinemaContext")
        {

        }

        public System.Data.Entity.DbSet<WebAppCinema.Models.Sessao> Sessaos { get; set; }

        public System.Data.Entity.DbSet<WebAppCinema.Models.Filme> Filmes { get; set; }

        public System.Data.Entity.DbSet<WebAppCinema.Models.Ator> Ators { get; set; }

        public System.Data.Entity.DbSet<WebAppCinema.Models.Ingresso> Ingressoes { get; set; }

        public System.Data.Entity.DbSet<WebAppCinema.Models.Sala> Salas { get; set; }
    }
}