using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndPrueba.Models;

namespace BackEndPrueba.Data
{
    public class BackEndPruebaContext : DbContext
    {
        public BackEndPruebaContext (DbContextOptions<BackEndPruebaContext> options)
            : base(options)
        {
        }

        public DbSet<BackEndPrueba.Models.Accesorios> Accesorios { get; set; }
    }
}
