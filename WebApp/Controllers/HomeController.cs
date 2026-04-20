using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //uso ViewData para enviar datos a la vista
            ViewData["Id"] = 1;
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "Xlight";
            ViewData["Numero de serie"] = "123456";
            ViewData["Situacion"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString();
            return View();
        }
    }
}