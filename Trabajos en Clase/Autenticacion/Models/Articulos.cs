using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autenticacion.Models
{
    public class Articulos
    {
        [Key]
        public int codigo { get; set; }

        public string tipo { get; set; }

        public string marca { get; set; }

        public string color { get; set; }

        public string precio { get; set; }

    }
}
