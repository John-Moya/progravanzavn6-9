using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Personal
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Salario { get; set; }
        public string Telefono { get; set; }
        public string Puesto { get; set; }
        public string Correo { get; set; }

    }
}
