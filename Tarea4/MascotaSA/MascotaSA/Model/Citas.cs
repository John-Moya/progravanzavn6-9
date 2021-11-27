using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaSA.Model
{
    public class Citas
    {
        public int ID { get; set; }
        public string HoraCita { get; set; }
        public string PrecioProcedimiento { get; set; }
        public string NombreMascota { get; set; }
        public string Propietario { get; set; }
    }
}
