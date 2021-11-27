using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Municipalidad.Modelo
{
    public class Parquimetros
    {
        [Key]
        public int ID { get; set; }
        public string Localizacion { get; set; }
        public int Precio { get; set; }
        public string Supervisor { get; set; }

    }
}
