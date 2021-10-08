using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Cuarto
    {
        public int Id { get; set; }
        public string NumCuarto { get; set; }
        public string TipoCuarto { get; set; }
        public string Piso { get; set; }
        public string Estado { get; set; }
    }
}
