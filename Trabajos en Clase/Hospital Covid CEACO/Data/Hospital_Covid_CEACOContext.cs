using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hospital_Covid_CEACO.Models;

namespace Hospital_Covid_CEACO.Data
{
    public class Hospital_Covid_CEACOContext : DbContext
    {
        public Hospital_Covid_CEACOContext (DbContextOptions<Hospital_Covid_CEACOContext> options)
            : base(options)
        {
        }

        public DbSet<Hospital_Covid_CEACO.Models.Camillas> Camillas { get; set; }
    }
}
