namespace MesaLivre.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Update(T entity);    
        T Insert(T entity);
        bool Delete (T entity);
    }
}
