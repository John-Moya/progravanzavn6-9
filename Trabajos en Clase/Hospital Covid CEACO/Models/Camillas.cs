using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Covid_CEACO.Models
{
    public class Camillas
    {
        [Key]
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string numeroCamilla { get; set; }
        public string estadoDeIngreso { get; set; }

    }
}
