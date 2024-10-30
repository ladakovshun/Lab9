using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;
using WebApplication9.Services;
using System.Collections.Generic;

namespace WebApplication9.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.GetProducts(); // Отримання продуктів
            return View(products); // Передача продуктів у представлення
        }
    }
}
