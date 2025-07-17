using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public bool Genero { get; set; }
        public string ImagenURL { get; set; }
        public ICollection<Debilidad> Debilidades { get; set; } = [];
        public ICollection<Habilidad> Habilidades { get; set; } = [];
        public int EstadisticasId { get; set; }
        public required Estadistica Estadisticas { get; set; }
        public ICollection<Tipo> Tipos { get; set; } = [];
        public int EspeciesId { get; set; }
        public required Especie Especies { get; set; }

    }
}
