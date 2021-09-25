using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentaCasas.Models;

namespace VentaCasas.Data
{
    public class VentaCasasContext : DbContext
    {
        public VentaCasasContext (DbContextOptions<VentaCasasContext> options)
            : base(options)
        {
        }

        public DbSet<VentaCasas.Models.Casa> Casa { get; set; }
    }
}
