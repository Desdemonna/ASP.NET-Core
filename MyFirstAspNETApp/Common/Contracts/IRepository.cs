using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlinePizzeria.Infrastructure.Common.Contracts
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> All();
        Task<IEnumerable<TEntity>> AllAsNoTracking();
        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity> FindOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChangesAsync();
    }
}
