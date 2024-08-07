using MesaLivre.Database;
using MesaLivre.Models;
using MesaLivre.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MesaLivre.Repositories
{
    public class RestauranteRepository : BaseRepository<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
