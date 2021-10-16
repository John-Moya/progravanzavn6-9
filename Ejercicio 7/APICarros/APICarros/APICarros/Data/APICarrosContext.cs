using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APICarros.Models;

namespace APICarros.Data
{
    public class APICarrosContext : DbContext
    {
        public APICarrosContext (DbContextOptions<APICarrosContext> options)
            : base(options)
        {
        }

        public DbSet<APICarros.Models.Carro> Carro { get; set; }
    }
}
