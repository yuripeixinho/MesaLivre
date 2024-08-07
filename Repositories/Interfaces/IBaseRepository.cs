namespace MesaLivre.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Update(T entity);
        Task<T> Insert(T entity);
        Task<bool> Delete(int id);
    }
}