using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIPaniamor;

namespace APIPaniamor.Data
{
    public class APIPaniamorContext : DbContext
    {
        public APIPaniamorContext (DbContextOptions<APIPaniamorContext> options)
            : base(options)
        {
        }

        public DbSet<APIPaniamor.Tramite> Tramite { get; set; }
    }
}
