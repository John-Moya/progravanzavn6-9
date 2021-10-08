using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Venta_de_Casas.Models;

namespace Venta_de_Casas.Data
{
    public class Venta_de_CasasContext : DbContext
    {
        public Venta_de_CasasContext (DbContextOptions<Venta_de_CasasContext> options)
            : base(options)
        {
        }

        public DbSet<Venta_de_Casas.Models.Casa> Casa { get; set; }
    }
}
