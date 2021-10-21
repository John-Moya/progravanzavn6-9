using System;
using System.ComponentModel.DataAnnotations;

namespace ApiArticulos.Models
{
    public class Articulos
    {
        [Key]
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Impuesto { get; set; }
    }
}
