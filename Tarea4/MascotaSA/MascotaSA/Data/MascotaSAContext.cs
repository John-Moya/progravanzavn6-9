using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MascotaSA.Model;

namespace MascotaSA.Data
{
    public class MascotaSAContext : DbContext
    {
        public MascotaSAContext (DbContextOptions<MascotaSAContext> options)
            : base(options)
        {
        }

        public DbSet<MascotaSA.Model.Citas> Citas { get; set; }
    }
}
