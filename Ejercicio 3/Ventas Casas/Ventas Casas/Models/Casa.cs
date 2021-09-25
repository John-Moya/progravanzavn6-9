using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ventas_Casas.Models
{
    public class Casa
    {
        [Key]
        public int ID { get; set; }
        public string Direccion { get; set; }
        public string Cuartos { get; set; }
        public string Metros { get; set; }
        public string Baños { get; set; }
        public string Precio { get; set; }
    }
}
