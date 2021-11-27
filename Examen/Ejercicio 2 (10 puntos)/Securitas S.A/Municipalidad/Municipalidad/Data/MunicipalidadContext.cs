using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Municipalidad.Modelo;

namespace Municipalidad.Data
{
    public class MunicipalidadContext : DbContext
    {
        public MunicipalidadContext (DbContextOptions<MunicipalidadContext> options)
            : base(options)
        {
        }

        public DbSet<Municipalidad.Modelo.Parquimetros> Parquimetros { get; set; }
    }
}
