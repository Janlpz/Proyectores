using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //viewbag es un objeto dinámico que permite enviar datos a la vista sin necesidad de definir una clase específica para ello

            //uso viewdata para enviar datos a la vista
            //viewbag.id = 2;
            //viewbag.marca = "epson";
            //viewbag.modelo = "xlight";
            //viewbag.numerodeserie = "123456";
            //viewbag.situacion = "bueno";
            //viewbag.fechadealta = datetime.now.tostring();
            //return view();

            //Uso de modelo de la vista  
            
            var modelo = LoadDATA();

            //var modelo = new List<proyector()>;

            return View(modelo);
        }

        private IEnumerable<Proyector> LoadDATA()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()

            {
                Id = 1,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            return proyectores;
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