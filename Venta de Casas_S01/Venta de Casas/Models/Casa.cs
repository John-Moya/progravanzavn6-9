using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta_de_Casas.Models
{
    public class Casa
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Cuartos { get; set; }
        public string Metros { get; set; }
        public string Precio { get; set; }
        public string Banos { get; set; }
    }
}
