using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }
        public Contexto(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Especie> Especie { get; set; }
        public virtual DbSet<Habitat> Habitat { get; set; }
        public virtual DbSet<Itinerario> Itinerario { get; set; }
        public virtual DbSet<Viven> Viven { get; set; }
    }
}
