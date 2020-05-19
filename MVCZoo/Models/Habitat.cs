using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Habitat
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clima { get; set; }
        public string Vegetacion { get; set; }
        public int ItinerarioId { get; set; }
        public Itinerario Itinerario { get; set; }
        public ICollection<Viven> Viven { get; set; }
    }
}
