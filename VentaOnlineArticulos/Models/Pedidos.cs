using System;
using System.ComponentModel.DataAnnotations;

namespace VentaOnlineArticulos.Models
{
    public class Pedidos
    {
        [Key]
        public int idPedido { get; set; }
        public string idArticulos { get; set; }
        public DateTime facha { get; set; }




    }
}
