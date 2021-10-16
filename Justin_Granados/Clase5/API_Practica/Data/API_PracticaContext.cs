using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Practica.Models;

namespace API_Practica.Data
{
    public class API_PracticaContext : DbContext
    {
        public API_PracticaContext (DbContextOptions<API_PracticaContext> options)
            : base(options)
        {
        }

        public DbSet<API_Practica.Models.Accesorios> Accesorios { get; set; }
    }
}
