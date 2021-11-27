using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalPaginaWeb.Models
{
    public class Doctor
    {
        [Key]
        public int CedulaDoctor { get; set; }
        public string Especialidad { get; set; }
        public int Salario { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}
