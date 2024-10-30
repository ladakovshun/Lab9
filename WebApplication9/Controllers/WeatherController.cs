using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication9.Services;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task<IActionResult> Index(string city)
    {
        var weather = await _weatherService.GetWeatherAsync(city);
        return View(weather);
    }
}

