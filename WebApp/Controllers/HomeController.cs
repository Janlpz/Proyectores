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
            ViewBag.Id = 2;
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "Xlight";
            ViewBag.NumeroDeSerie = "123456";
            ViewBag.Situacion = "Bueno";
            ViewBag.FechaDeAlta = DateTime.Now.ToString();
            return View();

            //Uso de modelo de la vista  
            Proyector proyector = new()

            {
                Id = 2,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            };


            return View(proyector);
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