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

        public async Task<Restaurante> GetRestauranteById(int id)
        {
            return await _context.Restaurantes
                          .Include(r => r.Endereco)
                          .Include(r => r.Telefones)
                          .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
