using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalPaginaWeb.Models;

namespace HospitalPaginaWeb.Data
{
    public class HospitalPaginaWebContext : DbContext
    {
        public HospitalPaginaWebContext (DbContextOptions<HospitalPaginaWebContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalPaginaWeb.Models.Persona> Persona { get; set; }

        public DbSet<HospitalPaginaWeb.Models.Padecimiento> Padecimiento { get; set; }

        public DbSet<HospitalPaginaWeb.Models.Doctor> Doctor { get; set; }
    }
}
