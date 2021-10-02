using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico.Models
{
    public class Historial
    {

        [Key]
        public int Id { get; set; }

        public string Aves { get; set; }

        public string Mamiferos { get; set; }

        public string Peces { get; set; }

        public string Reptiles { get; set; }
    }
}
