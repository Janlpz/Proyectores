using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();
        public void AddProyector(Proyector proyector)
        {

            if (proyector != null)
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
                Marca = "Hp",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Lg",
                Modelo = "Xlight674",
                NumeroDeSerie = "123788",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Sony",
                Modelo = "VPL-WX",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Samsung",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Panasonic",
                Modelo = "X4838",
                NumeroDeSerie = "58763",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            return proyectores;
        }

        public Proyector Get(int id)
        {
            throw new NotImplementedException();
        }

        public Proyector? GetProyector(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProyector(Proyector proyector)
        {
            throw new NotImplementedException();
        }

        public void DeleteProyector(int id)
        {
            throw new NotImplementedException();
        }

        public Proyector? DeleteProyector(Proyector proyector)
        {
            throw new NotImplementedException();
        }
    }
}