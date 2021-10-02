using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autenticacion.Models
{
    public class Articulo
    {
        [Key]
        public int ID_Articulo { get; set; }
        public string Nombre { get; set; }
        public int Cant_Stock { get; set; }
    }
}
