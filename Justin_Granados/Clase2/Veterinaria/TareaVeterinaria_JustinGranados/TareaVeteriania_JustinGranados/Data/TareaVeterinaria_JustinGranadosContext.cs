using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaVeterinaria_JustinGranados.Models;

namespace TareaVeterinaria_JustinGranados.Data
{
    public class TareaVeterinaria_JustinGranadosContext : DbContext
    {
        public TareaVeterinaria_JustinGranadosContext (DbContextOptions<TareaVeterinaria_JustinGranadosContext> options)
            : base(options)
        {
        }

        public DbSet<TareaVeterinaria_JustinGranados.Models.Veterinaria> Veterinaria { get; set; }

        public DbSet<TareaVeterinaria_JustinGranados.Models.Mascota> Mascota { get; set; }
    }
}
