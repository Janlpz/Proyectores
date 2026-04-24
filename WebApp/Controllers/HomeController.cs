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
            var modelo = LoadData();

            //var modelo = new List<proyector()>;

            return View(modelo);
        }

        private IEnumerable<Proyector> LoadData()
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
                Marca = "LG",
                Modelo = "XLig574",
                NumeroDeSerie = "123788",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Sony",
                Modelo = "VPL-XW5000",
                NumeroDeSerie = "123999",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Samsung",
                Modelo = "Xlig874",
                NumeroDeSerie = "15789",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Panasonic",
                Modelo = "X4874",
                NumeroDeSerie = "178921",
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