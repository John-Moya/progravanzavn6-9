using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentadeCasas.Models;

namespace VentadeCasas.Data
{
    public class VentadeCasasContext : DbContext
    {
        public VentadeCasasContext (DbContextOptions<VentadeCasasContext> options)
            : base(options)
        {
        }

        public DbSet<VentadeCasas.Models.Casa> Casa { get; set; }
    }
}
