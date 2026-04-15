using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return Content(

                "<h1>Proyectores</h1>"
                + "<p> Aqui se mostrara los detalles del proyecto</p>",
                "text/html"
            );
        }

        public IActionResult Details( int id)
        {
            return Content(
                "<h2>Nuevo Proyector</h2>" +
                "<p>Aqui se mostrara la informaci&oacute;n de un proyector espec&iacute;fico\n" + id + "</p>",
                "text/html"
            );
        }

        public IActionResult Delete(int id)
        {
            return Content(
                "<h2>Dar de baja</h2>" +
                "<p>Aqui se dara de baja el proyector\n" + id + "</p>",
                "text/html"
            );
        }


    }
}
