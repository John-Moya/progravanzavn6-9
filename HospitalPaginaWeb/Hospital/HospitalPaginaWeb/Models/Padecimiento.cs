using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalPaginaWeb.Models
{
    public class Padecimiento
    {
        [Key]
        public int Id { get; set; }
        public string NombrePadecimiento { get; set; }
        public string Tratamiento { get; set; }
        public int Cedula { get; set; }
        public int CedulaDoctor { get; set; }
    }
}
