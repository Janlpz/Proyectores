using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();
        public void AddProyector(Proyector proyector)
        {
            if (proyector !=null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
           
            return _proyectores;
        }

        private static List<Proyector> LoadData()
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

    }
}
