namespace Infrastructure.Repository;

public interface IRepository<T>
{
    Task<T> Add(T entity);
    Task<T?> GetById(int id);
    Task<IEnumerable<T?>> GetAll();
    Task<T?> DeleteById(int id);
    Task<T?> UpdateById(int id, T entity);
}
