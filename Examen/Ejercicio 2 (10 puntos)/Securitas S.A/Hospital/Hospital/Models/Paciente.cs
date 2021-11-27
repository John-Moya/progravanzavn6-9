using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Paciente
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Estadia { get; set; }
        public string Medico { get; set; }
        public string Enfermera { get; set; }

    }
}
