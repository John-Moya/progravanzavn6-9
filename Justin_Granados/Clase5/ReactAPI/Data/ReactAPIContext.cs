using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactAPI.Models;

namespace ReactAPI.Data
{
    public class ReactAPIContext : DbContext
    {
        public ReactAPIContext (DbContextOptions<ReactAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ReactAPI.Models.Articulo> Articulo { get; set; }
    }
}
