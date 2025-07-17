using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Entities;

namespace Pokedex.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Debilidad> Debilidades { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Estadistica> Estadisticas { get; set; }
        public DbSet<Habilidad> Habilidades { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
