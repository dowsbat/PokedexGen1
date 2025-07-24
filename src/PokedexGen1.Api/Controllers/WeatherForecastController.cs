using Microsoft.AspNetCore.Mvc;
using Pokedex.Application.Servicios;

namespace PokedexGen1.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IPokemonApiServicios _pokemonServices;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IPokemonApiServicios pokemonServices)
    {
        _logger = logger;
        _pokemonServices = pokemonServices;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("prueba")]
    public async Task<IActionResult> Prueba()
    {
        var service = await _pokemonServices.GetFirstGenPokemon();
        return Ok(service);

    }

}
