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
        private static Vector zapatos = new Vector();
        private static Vector sombreros = new Vector();
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

                case 3:
                zapatos.Adicionar(codigo, tipo);
                zapatos.PrintArray();
                return View();

                case 4:
                sombreros.Adicionar(codigo, tipo);
                sombreros.PrintArray();
                return View();

                default:
                return View();
            }
        }

        public IActionResult Camisas()
        {   
            Nodo referencia = camisas.cabecera.Siguiente;
            if (referencia == null)
            {
                ViewBag.Codigo1 = "";
                ViewBag.Nombre1 = "";
                ViewBag.Precio1 = "";
            }else
            {
                ViewBag.Codigo1 = camisas[0];
                ViewBag.Nombre1 = camisas.Nombre(1, camisas[0]);
                ViewBag.Precio1 = camisas.Precio(1, camisas[0]);
                referencia = referencia.Siguiente;
                if (referencia == null)
                {
                    ViewBag.Codigo2 = "";
                    ViewBag.Nombre2 = "";
                    ViewBag.Precio2 = "";
                }
                else
                {
                    ViewBag.Codigo2 = camisas[1];
                    ViewBag.Nombre2 = camisas.Nombre(1, camisas[1]);
                    ViewBag.Precio2 = camisas.Precio(1, camisas[1]);
                    referencia = referencia.Siguiente;
                    if (referencia == null)
                    {
                        ViewBag.Codigo3 = "";
                        ViewBag.Nombre3 = "";
                        ViewBag.Precio3 = "";
                    }
                    else
                    {
                        ViewBag.Codigo3 = camisas[2];
                        ViewBag.Nombre3 = camisas.Nombre(1, camisas[2]);
                        ViewBag.Precio3 = camisas.Precio(1, camisas[2]);
                        referencia = referencia.Siguiente;
                        if (referencia == null)
                        {
                            ViewBag.Codigo4 = "";
                            ViewBag.Nombre4 = "";
                            ViewBag.Precio4 = "";
                        }
                        else
                        {
                            ViewBag.Codigo4 = camisas[3];
                            ViewBag.Nombre4 = camisas.Nombre(1, camisas[3]);
                            ViewBag.Precio4 = camisas.Precio(1, camisas[3]);
                            referencia = referencia.Siguiente;
                            if (referencia == null)
                            {
                                ViewBag.Codigo5 = "";
                                ViewBag.Nombre5 = "";
                                ViewBag.Precio5 = "";
                            }
                            else
                            {
                                ViewBag.Codigo5 = camisas[4];
                                ViewBag.Nombre5 = camisas.Nombre(1, camisas[4]);
                                ViewBag.Precio5 = camisas.Precio(1, camisas[4]);
                                referencia = referencia.Siguiente;
                                if (referencia == null)
                                {
                                    ViewBag.Codigo6 = "";
                                    ViewBag.Nombre6 = "";
                                    ViewBag.Precio6 = "";
                                }
                                else
                                {
                                    ViewBag.Codigo6 = camisas[5];
                                    ViewBag.Nombre6 = camisas.Nombre(1, camisas[5]);
                                    ViewBag.Precio6 = camisas.Precio(1, camisas[5]);
                                    referencia = referencia.Siguiente;
                                    if (referencia == null)
                                    {
                                        ViewBag.Codigo7 = "";
                                        ViewBag.Nombre7 = "";
                                        ViewBag.Precio7 = "";
                                    }
                                    else
                                    {
                                        ViewBag.Codigo7 = camisas[6];
                                        ViewBag.Nombre7 = camisas.Nombre(1, camisas[6]);
                                        ViewBag.Precio7 = camisas.Precio(1, camisas[6]);
                                        referencia = referencia.Siguiente;
                                        if (referencia == null)
                                        {
                                            ViewBag.Codigo8 = "";
                                            ViewBag.Nombre8 = "";
                                            ViewBag.Precio8 = "";
                                        }
                                        else
                                        {
                                            ViewBag.Codigo8 = camisas[7];
                                            ViewBag.Nombre8 = camisas.Nombre(1, camisas[7]);
                                            ViewBag.Precio8 = camisas.Precio(1, camisas[7]);
                                            referencia = referencia.Siguiente;
                                            if (referencia == null)
                                            {
                                                ViewBag.Codigo9 = "";
                                                ViewBag.Nombre9 = "";
                                                ViewBag.Precio9 = "";
                                            }
                                            else
                                            {
                                                ViewBag.Codigo9 = camisas[8];
                                                ViewBag.Nombre9 = camisas.Nombre(1, camisas[8]);
                                                ViewBag.Precio9 = camisas.Precio(1, camisas[8]);
                                                referencia = referencia.Siguiente;
                                                if (referencia == null)
                                                {
                                                    ViewBag.Codigo10 = "";
                                                    ViewBag.Nombre10 = "";
                                                    ViewBag.Precio10 = "";
                                                }
                                                else
                                                {
                                                    ViewBag.Codigo10 = camisas[9];
                                                    ViewBag.Nombre10 = camisas.Nombre(1, camisas[9]);
                                                    ViewBag.Precio10 = camisas.Precio(1, camisas[9]);
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }    
                    }
                }
            }
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
