using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag es un objeto dinámico que permite enviar datos a la vista sin necesidad de definir una clase específica para ello

            //uso ViewData para enviar datos a la vista
            ViewData["Id"] = 1;
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "Xlight";
            ViewData["Numero de serie"] = "123456";
            ViewData["Situacion"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString();
            ViewBag.Id = 2;
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "Xlight";
            ViewBag.NumeroDeSerie = "123456";
            ViewBag.Situacion = "Bueno";
            ViewBag.FechaDeAlta = DateTime.Now.ToString();
            return View();
        }
    }
}