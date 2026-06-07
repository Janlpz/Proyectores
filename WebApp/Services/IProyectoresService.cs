using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);
        Proyector? GetProyector(int id);
        void UpdateProyector(Proyector proyector);
        Proyector? DeleteProyector(Proyector proyector);

    }
}
