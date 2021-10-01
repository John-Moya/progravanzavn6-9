using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semana2_VentaCasa.Models;

namespace Semana2_VentaCasa.Data
{
    public class Semana2_VentaCasaContext : DbContext
    {
        public Semana2_VentaCasaContext (DbContextOptions<Semana2_VentaCasaContext> options)
            : base(options)
        {
        }

        public DbSet<Semana2_VentaCasa.Models.Casa> Casa { get; set; }
    }
}
