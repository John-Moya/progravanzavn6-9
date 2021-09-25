using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaVeterinaria_JustinGranados.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public bool VacunasAlDia { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Dueno { get; set; }
    }
}
