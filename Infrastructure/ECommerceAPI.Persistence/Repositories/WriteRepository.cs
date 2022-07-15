using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private ECommerceAPIDbPostgreContext _context;

        public WriteRepository(ECommerceAPIDbPostgreContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public async Task<List<T>> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return entities;
            
        }

        public T Remove(T entity)
        {
            Table.Remove(entity);
            return entity;
        }

        public async Task<T> RemoveByIdAsync(string id)
        {
            T entityModel = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            var entity = Remove(entityModel);
            return entity;
        }

        public List<T> RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return entities;
        }

        public T Update(T entity)
        {
            Table.Update(entity);
            return entity;
            
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
