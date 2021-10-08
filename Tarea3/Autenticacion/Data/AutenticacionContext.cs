using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autenticacion.Controllers;

namespace Autenticacion.Data
{
    public class AutenticacionContext : DbContext
    {
        public AutenticacionContext (DbContextOptions<AutenticacionContext> options)
            : base(options)
        {
        }

        public DbSet<Autenticacion.Controllers.Articulos> Articulos { get; set; }

        public DbSet<Autenticacion.Controllers.Pedidos> Pedidos { get; set; }
    }
}
