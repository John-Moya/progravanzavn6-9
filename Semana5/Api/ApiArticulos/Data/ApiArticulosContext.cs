using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiArticulos.Models;

namespace ApiArticulos.Data
{
    public class ApiArticulosContext : DbContext
    {
        public ApiArticulosContext (DbContextOptions<ApiArticulosContext> options)
            : base(options)
        {
        }

        public DbSet<ApiArticulos.Models.Articulos> Articulos { get; set; }
    }
}
