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
            Nodo referencia = pantalones.cabecera.Siguiente;
            if (referencia == null)
            {
                ViewBag.Codigo1 = "";
                ViewBag.Nombre1 = "";
                ViewBag.Precio1 = "";
            }else
            {
                ViewBag.Codigo1 = pantalones[0];
                ViewBag.Nombre1 = pantalones.Nombre(2, pantalones[0]);
                ViewBag.Precio1 = pantalones.Precio(2, pantalones[0]);
                referencia = referencia.Siguiente;
                if (referencia == null)
                {
                    ViewBag.Codigo2 = "";
                    ViewBag.Nombre2 = "";
                    ViewBag.Precio2 = "";
                }
                else
                {
                    ViewBag.Codigo2 = pantalones[1];
                    ViewBag.Nombre2 = pantalones.Nombre(2, pantalones[1]);
                    ViewBag.Precio2 = pantalones.Precio(2, pantalones[1]);
                    referencia = referencia.Siguiente;
                    if (referencia == null)
                    {
                        ViewBag.Codigo3 = "";
                        ViewBag.Nombre3 = "";
                        ViewBag.Precio3 = "";
                    }
                    else
                    {
                        ViewBag.Codigo3 = pantalones[2];
                        ViewBag.Nombre3 = pantalones.Nombre(2, pantalones[2]);
                        ViewBag.Precio3 = pantalones.Precio(2, pantalones[2]);
                        referencia = referencia.Siguiente;
                        if (referencia == null)
                        {
                            ViewBag.Codigo4 = "";
                            ViewBag.Nombre4 = "";
                            ViewBag.Precio4 = "";
                        }
                        else
                        {
                            ViewBag.Codigo4 = pantalones[3];
                            ViewBag.Nombre4 = pantalones.Nombre(2, pantalones[3]);
                            ViewBag.Precio4 = pantalones.Precio(2, pantalones[3]);
                            referencia = referencia.Siguiente;
                            if (referencia == null)
                            {
                                ViewBag.Codigo5 = "";
                                ViewBag.Nombre5 = "";
                                ViewBag.Precio5 = "";
                            }
                            else
                            {
                                ViewBag.Codigo5 = pantalones[4];
                                ViewBag.Nombre5 = pantalones.Nombre(2, pantalones[4]);
                                ViewBag.Precio5 = pantalones.Precio(2, pantalones[4]);
                                referencia = referencia.Siguiente;
                                if (referencia == null)
                                {
                                    ViewBag.Codigo6 = "";
                                    ViewBag.Nombre6 = "";
                                    ViewBag.Precio6 = "";
                                }
                                else
                                {
                                    ViewBag.Codigo6 = pantalones[5];
                                    ViewBag.Nombre6 = pantalones.Nombre(2, pantalones[5]);
                                    ViewBag.Precio6 = pantalones.Precio(2, pantalones[5]);
                                    referencia = referencia.Siguiente;
                                    if (referencia == null)
                                    {
                                        ViewBag.Codigo7 = "";
                                        ViewBag.Nombre7 = "";
                                        ViewBag.Precio7 = "";
                                    }
                                    else
                                    {
                                        ViewBag.Codigo7 = pantalones[6];
                                        ViewBag.Nombre7 = pantalones.Nombre(2, pantalones[6]);
                                        ViewBag.Precio7 = pantalones.Precio(2, pantalones[6]);
                                        referencia = referencia.Siguiente;
                                        if (referencia == null)
                                        {
                                            ViewBag.Codigo8 = "";
                                            ViewBag.Nombre8 = "";
                                            ViewBag.Precio8 = "";
                                        }
                                        else
                                        {
                                            ViewBag.Codigo8 = pantalones[7];
                                            ViewBag.Nombre8 = pantalones.Nombre(2, pantalones[7]);
                                            ViewBag.Precio8 = pantalones.Precio(2, pantalones[7]);
                                            referencia = referencia.Siguiente;
                                            if (referencia == null)
                                            {
                                                ViewBag.Codigo9 = "";
                                                ViewBag.Nombre9 = "";
                                                ViewBag.Precio9 = "";
                                            }
                                            else
                                            {
                                                ViewBag.Codigo9 = pantalones[8];
                                                ViewBag.Nombre9 = pantalones.Nombre(2, pantalones[8]);
                                                ViewBag.Precio9 = pantalones.Precio(2, pantalones[8]);
                                                referencia = referencia.Siguiente;
                                                if (referencia == null)
                                                {
                                                    ViewBag.Codigo10 = "";
                                                    ViewBag.Nombre10 = "";
                                                    ViewBag.Precio10 = "";
                                                }
                                                else
                                                {
                                                    ViewBag.Codigo10 = pantalones[9];
                                                    ViewBag.Nombre10 = pantalones.Nombre(2, pantalones[9]);
                                                    ViewBag.Precio10 = pantalones.Precio(2, pantalones[9]);
                                                    
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
        public IActionResult Zapatos()
        {
            int indice = 0;
            if (zapatos.producto[0] == 0)
            {
                ViewBag.Codigo1 = "";
                ViewBag.Nombre1 = "";
                ViewBag.Precio1 = "";
            }else
            {
                ViewBag.Codigo1 = zapatos.producto[0];
                ViewBag.Nombre1 = zapatos.nombre[0];
                ViewBag.Precio1 = zapatos.precio[0];
                indice++;
                if (zapatos.producto[indice] == 0)
                {
                    ViewBag.Codigo2 = "";
                    ViewBag.Nombre2 = "";
                    ViewBag.Precio2 = "";
                }
                else
                {
                    ViewBag.Codigo2 = zapatos.producto[1];
                    ViewBag.Nombre2 = zapatos.nombre[1];
                    ViewBag.Precio2 = zapatos.precio[1];
                    indice++;
                    if (zapatos.producto[indice] == 0)
                    {
                        ViewBag.Codigo3 = "";
                        ViewBag.Nombre3 = "";
                        ViewBag.Precio3 = "";
                    }
                    else
                    {
                        ViewBag.Codigo3 = zapatos.producto[2];
                        ViewBag.Nombre3 = zapatos.nombre[2];
                        ViewBag.Precio3 = zapatos.precio[2];
                        indice++;
                        if (zapatos.producto[indice] == 0)
                        {
                            ViewBag.Codigo4 = "";
                            ViewBag.Nombre4 = "";
                            ViewBag.Precio4 = "";
                        }
                        else
                        {
                            ViewBag.Codigo4 = zapatos.producto[3];
                            ViewBag.Nombre4 = zapatos.nombre[3];
                            ViewBag.Precio4 = zapatos.precio[3];
                            indice++;
                            if (zapatos.producto[indice] == 0)
                            {
                                ViewBag.Codigo5 = "";
                                ViewBag.Nombre5 = "";
                                ViewBag.Precio5 = "";
                            }
                            else
                            {
                                ViewBag.Codigo5 = zapatos.producto[4];
                                ViewBag.Nombre5 = zapatos.nombre[4];
                                ViewBag.Precio5 = zapatos.precio[4];
                                indice++;
                                if (zapatos.producto[indice] == 0)
                                {
                                    ViewBag.Codigo6 = "";
                                    ViewBag.Nombre6 = "";
                                    ViewBag.Precio6 = "";
                                }
                                else
                                {
                                    ViewBag.Codigo6 = zapatos.producto[5];
                                    ViewBag.Nombre6 = zapatos.nombre[5];
                                    ViewBag.Precio6 = zapatos.precio[5];
                                    indice++;
                                    if (zapatos.producto[indice] == 0)
                                    {
                                        ViewBag.Codigo7 = "";
                                        ViewBag.Nombre7 = "";
                                        ViewBag.Precio7 = "";
                                    }
                                    else
                                    {
                                        ViewBag.Codigo7 = zapatos.producto[6];
                                        ViewBag.Nombre7 = zapatos.nombre[6];
                                        ViewBag.Precio7 = zapatos.precio[6];
                                        indice++;
                                        if (zapatos.producto[indice] == 0)
                                        {
                                            ViewBag.Codigo8 = "";
                                            ViewBag.Nombre8 = "";
                                            ViewBag.Precio8 = "";
                                        }
                                        else
                                        {
                                            ViewBag.Codigo8 = zapatos.producto[7];
                                            ViewBag.Nombre8 = zapatos.nombre[7];
                                            ViewBag.Precio8 = zapatos.precio[7];
                                            indice++;
                                            if (zapatos.producto[indice] == 0)
                                            {
                                                ViewBag.Codigo9 = "";
                                                ViewBag.Nombre9 = "";
                                                ViewBag.Precio9 = "";
                                            }
                                            else
                                            {
                                                ViewBag.Codigo9 = zapatos.producto[8];
                                                ViewBag.Nombre9 = zapatos.nombre[8];
                                                ViewBag.Precio9 = zapatos.precio[8];
                                                indice++;
                                                if (zapatos.producto[indice] == 0)
                                                {
                                                    ViewBag.Codigo10 = "";
                                                    ViewBag.Nombre10 = "";
                                                    ViewBag.Precio10 = "";
                                                }
                                                else
                                                {
                                                    ViewBag.Codigo10 = zapatos.producto[9];
                                                    ViewBag.Nombre10 = zapatos.nombre[9];
                                                    ViewBag.Precio10 = zapatos.precio[9];
                                                    
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
        public IActionResult Sombreros()
        {
            int indice = 0;
            if (sombreros.producto[0] == 0)
            {
                ViewBag.Codigo1 = "";
                ViewBag.Nombre1 = "";
                ViewBag.Precio1 = "";
            }else
            {
                ViewBag.Codigo1 = sombreros.producto[0];
                ViewBag.Nombre1 = sombreros.nombre[0];
                ViewBag.Precio1 = sombreros.precio[0];
                indice++;
                if (sombreros.producto[indice] == 0)
                {
                    ViewBag.Codigo2 = "";
                    ViewBag.Nombre2 = "";
                    ViewBag.Precio2 = "";
                }
                else
                {
                    ViewBag.Codigo2 = sombreros.producto[1];
                    ViewBag.Nombre2 = sombreros.nombre[1];
                    ViewBag.Precio2 = sombreros.precio[1];
                    indice++;
                    if (sombreros.producto[indice] == 0)
                    {
                        ViewBag.Codigo3 = "";
                        ViewBag.Nombre3 = "";
                        ViewBag.Precio3 = "";
                    }
                    else
                    {
                        ViewBag.Codigo3 = sombreros.producto[2];
                        ViewBag.Nombre3 = sombreros.nombre[2];
                        ViewBag.Precio3 = sombreros.precio[2];
                        indice++;
                        if (sombreros.producto[indice] == 0)
                        {
                            ViewBag.Codigo4 = "";
                            ViewBag.Nombre4 = "";
                            ViewBag.Precio4 = "";
                        }
                        else
                        {
                            ViewBag.Codigo4 = sombreros.producto[3];
                            ViewBag.Nombre4 = sombreros.nombre[3];
                            ViewBag.Precio4 = sombreros.precio[3];
                            indice++;
                            if (sombreros.producto[indice] == 0)
                            {
                                ViewBag.Codigo5 = "";
                                ViewBag.Nombre5 = "";
                                ViewBag.Precio5 = "";
                            }
                            else
                            {
                                ViewBag.Codigo5 = sombreros.producto[4];
                                ViewBag.Nombre5 = sombreros.nombre[4];
                                ViewBag.Precio5 = sombreros.precio[4];
                                indice++;
                                if (sombreros.producto[indice] == 0)
                                {
                                    ViewBag.Codigo6 = "";
                                    ViewBag.Nombre6 = "";
                                    ViewBag.Precio6 = "";
                                }
                                else
                                {
                                    ViewBag.Codigo6 = sombreros.producto[5];
                                    ViewBag.Nombre6 = sombreros.nombre[5];
                                    ViewBag.Precio6 = sombreros.precio[5];
                                    indice++;
                                    if (sombreros.producto[indice] == 0)
                                    {
                                        ViewBag.Codigo7 = "";
                                        ViewBag.Nombre7 = "";
                                        ViewBag.Precio7 = "";
                                    }
                                    else
                                    {
                                        ViewBag.Codigo7 = sombreros.producto[6];
                                        ViewBag.Nombre7 = sombreros.nombre[6];
                                        ViewBag.Precio7 = sombreros.precio[6];
                                        indice++;
                                        if (sombreros.producto[indice] == 0)
                                        {
                                            ViewBag.Codigo8 = "";
                                            ViewBag.Nombre8 = "";
                                            ViewBag.Precio8 = "";
                                        }
                                        else
                                        {
                                            ViewBag.Codigo8 = sombreros.producto[7];
                                            ViewBag.Nombre8 = sombreros.nombre[7];
                                            ViewBag.Precio8 = sombreros.precio[7];
                                            indice++;
                                            if (sombreros.producto[indice] == 0)
                                            {
                                                ViewBag.Codigo9 = "";
                                                ViewBag.Nombre9 = "";
                                                ViewBag.Precio9 = "";
                                            }
                                            else
                                            {
                                                ViewBag.Codigo9 = sombreros.producto[8];
                                                ViewBag.Nombre9 = sombreros.nombre[8];
                                                ViewBag.Precio9 = sombreros.precio[8];
                                                indice++;
                                                if (sombreros.producto[indice] == 0)
                                                {
                                                    ViewBag.Codigo10 = "";
                                                    ViewBag.Nombre10 = "";
                                                    ViewBag.Precio10 = "";
                                                }
                                                else
                                                {
                                                    ViewBag.Codigo10 = sombreros.producto[9];
                                                    ViewBag.Nombre10 = sombreros.nombre[9];
                                                    ViewBag.Precio10 = sombreros.precio[9];
                                                    
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
