using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentasMascotas.Models;

namespace VentasMascotas.Data
{
    public class VentasMascotasContext : DbContext
    {
        public VentasMascotasContext (DbContextOptions<VentasMascotasContext> options)
            : base(options)
        {
        }

        public DbSet<VentasMascotas.Models.Accesorios> Accesorios { get; set; }
    }
}
