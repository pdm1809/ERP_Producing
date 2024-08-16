using System.Linq.Expressions;

namespace SampleProject.Data.Repositories.Abstractions
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(object id);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression = null);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression = null);
        Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<IEnumerable<TEntity>> InsertRangeAsync(IList<TEntity> entities);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> UpdateRange(IList<TEntity> entities);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> expression = null);
        void Delete(TEntity entity);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null);
    }
}
