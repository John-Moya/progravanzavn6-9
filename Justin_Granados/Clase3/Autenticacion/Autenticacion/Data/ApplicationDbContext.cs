﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Autenticacion.Models;

namespace Autenticacion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Autenticacion.Models.Pedido> Pedido { get; set; }
        public DbSet<Autenticacion.Models.Articulo> Articulo { get; set; }
    }
}
