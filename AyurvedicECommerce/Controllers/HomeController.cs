using AyurvedicECommerce.Models;
using AyurvedicECommerce.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepositery _productRepositery;


        public HomeController(ILogger<HomeController> logger, IProductRepositery productRepositery)
        {
            _productRepositery = productRepositery;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_productRepositery.GetProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
