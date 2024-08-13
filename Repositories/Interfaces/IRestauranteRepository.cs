using MesaLivre.Models;

namespace MesaLivre.Repositories.Interfaces
{
    public interface IRestauranteRepository : IBaseRepository<Restaurante>
    {
        Task<Restaurante> GetRestauranteById(int id);
    }
}
