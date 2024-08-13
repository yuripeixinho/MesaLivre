using MesaLivre.Database;
using MesaLivre.Models;
using MesaLivre.Repositories.Interfaces;

namespace MesaLivre.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
