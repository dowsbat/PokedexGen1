using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PokedexOG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Debilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadisticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PS = table.Column<int>(type: "int", nullable: false),
                    Ataque = table.Column<int>(type: "int", nullable: false),
                    Defensa = table.Column<int>(type: "int", nullable: false),
                    AtaqueEspecial = table.Column<int>(type: "int", nullable: false),
                    DefensaEspecial = table.Column<int>(type: "int", nullable: false),
                    Velocidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Genero = table.Column<bool>(type: "bit", nullable: false),
                    ImagenURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadisticasId = table.Column<int>(type: "int", nullable: false),
                    EspeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Especies_EspeciesId",
                        column: x => x.EspeciesId,
                        principalTable: "Especies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Estadisticas_EstadisticasId",
                        column: x => x.EstadisticasId,
                        principalTable: "Estadisticas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebilidadPokemon",
                columns: table => new
                {
                    DebilidadesId = table.Column<int>(type: "int", nullable: false),
                    PokemonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebilidadPokemon", x => new { x.DebilidadesId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_DebilidadPokemon_Debilidades_DebilidadesId",
                        column: x => x.DebilidadesId,
                        principalTable: "Debilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebilidadPokemon_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadPokemon",
                columns: table => new
                {
                    HabilidadesId = table.Column<int>(type: "int", nullable: false),
                    PokemonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadPokemon", x => new { x.HabilidadesId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_HabilidadPokemon_Habilidades_HabilidadesId",
                        column: x => x.HabilidadesId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabilidadPokemon_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTipo",
                columns: table => new
                {
                    PokemonsId = table.Column<int>(type: "int", nullable: false),
                    TiposId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTipo", x => new { x.PokemonsId, x.TiposId });
                    table.ForeignKey(
                        name: "FK_PokemonTipo_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTipo_Tipos_TiposId",
                        column: x => x.TiposId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DebilidadPokemon_PokemonsId",
                table: "DebilidadPokemon",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadPokemon_PokemonsId",
                table: "HabilidadPokemon",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_EspeciesId",
                table: "Pokemons",
                column: "EspeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_EstadisticasId",
                table: "Pokemons",
                column: "EstadisticasId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTipo_TiposId",
                table: "PokemonTipo",
                column: "TiposId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DebilidadPokemon");

            migrationBuilder.DropTable(
                name: "HabilidadPokemon");

            migrationBuilder.DropTable(
                name: "PokemonTipo");

            migrationBuilder.DropTable(
                name: "Debilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "Estadisticas");
        }
    }
}
