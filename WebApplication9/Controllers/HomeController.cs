using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication9.Models;
using WebApplication9.Services;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Phone Samsung Galaxy A31", Price = 599.99M, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Headphones JBL710", Price = 199.99M, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Case for Samsung Galaxy A31", Price = 29.99M, CreatedDate = DateTime.Now }
            };

            // Отримання погоди для Миколаєва
            var weather = await _weatherService.GetWeatherAsync("Mykolaiv,UA");
            ViewBag.Weather = weather; // Передача даних про погоду у ViewBag

            return View(products); // Повернення списку продуктів у представлення
        }
    }
}
