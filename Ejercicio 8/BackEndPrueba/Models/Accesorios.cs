using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPrueba.Models
{
    public class Accesorios
    {
        [Key]
        public int ID { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Impuesto { get; set; }

    }
}
