using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Semana2_Practica.Models
{
    public class Expediente
    {

        [Key]
        public int IdMascota { get; set; }

        public string Nombre { get; set; }

        public string Especie { get; set; }

        public string Raza { get; set; }

        public string Color { get; set; }

        public string Edad { get; set; }

        public string Peso { get; set; }

        public string Sexo { get; set; }

    }
}
