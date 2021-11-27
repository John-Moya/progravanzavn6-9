using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Securitas_S.A_.Modelo;

namespace Securitas_S.A_.Data
{
    public class Securitas_SA_Context : DbContext
    {
        public Securitas_SA_Context (DbContextOptions<Securitas_SA_Context> options)
            : base(options)
        {
        }

        public DbSet<Securitas_S.A_.Modelo.Camiones> Camiones { get; set; }
    }
}
