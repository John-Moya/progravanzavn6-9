using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VentaOnlineArticulos.Models;

namespace VentaOnlineArticulos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VentaOnlineArticulos.Models.Articulos> Articulos { get; set; }
        public DbSet<VentaOnlineArticulos.Models.Pedidos> Pedidos { get; set; }
    }
}
