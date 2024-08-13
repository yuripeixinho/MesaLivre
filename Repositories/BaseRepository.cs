using MesaLivre.Database;
using MesaLivre.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MesaLivre.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class 
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity); 
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
                throw new Exception("Ocorreu um problema ao deletar");
            
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
