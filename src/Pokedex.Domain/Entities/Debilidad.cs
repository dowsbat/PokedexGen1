namespace Pokedex.Domain.Entities
{
    public class Debilidad
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; } = [];
    }
}
