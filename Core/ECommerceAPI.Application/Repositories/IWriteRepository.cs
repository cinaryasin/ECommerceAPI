
using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> AddRangeAsync(List<T> entities);
        T Update(T entity);
        T Remove(T entity);
        List<T> RemoveRange(List<T> entities);
        Task<T> RemoveByIdAsync(string id);
        Task<int> SaveAsync();
    }
}
