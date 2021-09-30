using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Cuartos
    {
        public int Id { get; set; }
        public string NumCuarto { get; set; }
        public string TipoCuarto { get; set; }
        public string Precio { get; set; }
        public string Piso { get; set; }
        public string Estado { get; set; }
    }
}
