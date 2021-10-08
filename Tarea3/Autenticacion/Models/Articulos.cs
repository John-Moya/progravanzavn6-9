using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autenticacion.Controllers
{
    public class Articulos
    {
        [Key]
        public int idArticulo { get; set; }

        public string  Articulo { get; set; }
        public string Usuario { get; set; }
        public string Cantidad { get; set; }
    }
}
