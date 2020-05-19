using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Viven
    {
        public int Id { get; set; }
        public int HabitatId { get; set; }
        public Habitat Habitat { get; set; }
        public int EspecieId { get; set; }
        public Especie Especie { get; set; }
        public int Indice { get; set; }
    }
}
