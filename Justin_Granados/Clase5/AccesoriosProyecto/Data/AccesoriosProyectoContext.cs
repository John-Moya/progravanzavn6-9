using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccesoriosProyecto.Models;

namespace AccesoriosProyecto.Data
{
    public class AccesoriosProyectoContext : DbContext
    {
        public AccesoriosProyectoContext (DbContextOptions<AccesoriosProyectoContext> options)
            : base(options)
        {
        }

        public DbSet<AccesoriosProyecto.Models.Accesorios> Accesorios { get; set; }
    }
}
