using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Descripcion { get; set; }
        public string Precio_Promo { get; set; }
        public string Tiempo_Espera { get; set; }
        public string Precio { get; set; }
    }
}
