using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiCarros.Models;

namespace ApiCarros.Data
{
    public class ApiCarrosContext : DbContext
    {
        public ApiCarrosContext (DbContextOptions<ApiCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<ApiCarros.Models.Automovil> Automovil { get; set; }
    }
}
