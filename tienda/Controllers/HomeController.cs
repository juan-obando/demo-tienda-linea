using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tienda.Models;

namespace tienda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Pre
        public IActionResult Index()
        {
            
            return View();
        }
        //Post
        [HttpPost]
        public ActionResult Index(Nodo a, int codigo, string nombre, int precio){
            a.Codigo = codigo;
            a.Nombre = nombre;
            a.Precio = precio;

            ViewBag.Codigo = a.Codigo;
            ViewBag.Nombre = a.Nombre;
            ViewBag.Precio = a.Precio;
            return View();
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
