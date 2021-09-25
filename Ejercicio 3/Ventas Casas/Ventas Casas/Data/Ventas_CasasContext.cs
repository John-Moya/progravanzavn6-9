using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ventas_Casas.Models;

namespace Ventas_Casas.Data
{
    public class Ventas_CasasContext : DbContext
    {
        public Ventas_CasasContext (DbContextOptions<Ventas_CasasContext> options)
            : base(options)
        {
        }

        public DbSet<Ventas_Casas.Models.Casa> Casa { get; set; }
    }
}
