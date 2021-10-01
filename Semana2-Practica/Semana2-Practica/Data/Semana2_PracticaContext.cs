using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semana2_Practica.Models;

namespace Semana2_Practica.Data
{
    public class Semana2_PracticaContext : DbContext
    {
        public Semana2_PracticaContext (DbContextOptions<Semana2_PracticaContext> options)
            : base(options)
        {
        }

        public DbSet<Semana2_Practica.Models.Expediente> Expediente { get; set; }
    }
}
