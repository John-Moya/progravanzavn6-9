using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Securitas_S.A_.Modelo
{
    public class Camiones
    {
        [Key]
        public int ID { get; set; }
        public string Placa { get; set; }
        public string Peso { get; set; }
        public string Ruta { get; set; }
        public string Chofer { get; set; }
    }
}
