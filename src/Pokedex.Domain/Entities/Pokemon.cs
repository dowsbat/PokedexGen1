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
        public List<Debilidad> Debilidades { get; set; } = [];
        public List<Habilidad> Habilidades { get; set; } = [];
        public int EstadisticasId { get; set; }
        public required Estadistica Estadisticas { get; set; }
        public List<Tipo> Tipos { get; set; } = [];
        public int EspeciesId { get; set; }
        public required Especie Especies { get; set; }

    }
}
