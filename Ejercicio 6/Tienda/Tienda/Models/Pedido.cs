using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public string Articulo { get; set; }
        public string Usuario { get; set; }
        public int Cantidad { get; set; }
    }
}
