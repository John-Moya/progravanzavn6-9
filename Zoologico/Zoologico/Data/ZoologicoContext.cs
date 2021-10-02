using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zoologico.Models;

namespace Zoologico.Data
{
    public class ZoologicoContext : DbContext
    {
        public ZoologicoContext (DbContextOptions<ZoologicoContext> options)
            : base(options)
        {
        }

        public DbSet<Zoologico.Models.Historial> Historial { get; set; }
    }
}
