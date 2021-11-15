using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autenticacion.Models
{
    public class Pedido
    {
        [Key]
        public int ID_Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreProducto { get; set; }
        public string Detalle { get; set; }
        public string NombreCliente { get; set; }
    }
}
