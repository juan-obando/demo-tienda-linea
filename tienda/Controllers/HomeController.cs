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
        private static ListaEnlazada camisas = new ListaEnlazada();
        private static ListaEnlazada pantalones = new ListaEnlazada();
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
        public ActionResult Index(int tipo, int codigo)
        {
            switch (tipo)
            {
                case 1:
                camisas.Adicionar(codigo, tipo);
                camisas.Apuntador();
                return View();
                case 2:
                pantalones.Adicionar(codigo, tipo);
                pantalones.Apuntador();
                return View();

                default:
                return View();
            }
        }

        public IActionResult Camisas()
        {
            return View();
        }
        public IActionResult Pantalones()
        {
            return View();
        }
        public IActionResult Zapatos()
        {
            return View();
        }
        public IActionResult Sombreros()
        {
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
