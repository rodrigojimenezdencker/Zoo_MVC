using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string Nombre_Comun { get; set; }
        public string Nombre_Cientifico { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Viven> Viven { get; set; }
    }
}
