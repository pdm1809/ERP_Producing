using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SampleProject.Data.Repositories.Abstractions;
using SampleProject.Shared.Providers.Abstractions;
using System.Linq.Expressions;

namespace SampleProject.Data.Repositories.Implements
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly DbSet<TEntity> _entities;
        protected readonly DatabaseFacade _database;

        protected RepositoryBase(DbContext dbContext, ICoreProvider coreProvider)
        {
            _entities = dbContext.Set<TEntity>();
            _database = dbContext.Database;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await (expression is null ? _entities.CountAsync() : _entities.CountAsync(expression));
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _entities.FindAsync(id);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = _entities.AsQueryable();

            if (expression is not null)
            {
                entities = entities.Where(expression);
            }

            return entities;
        }

        public async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await Find(expression).ToListAsync();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> InsertRangeAsync(IList<TEntity> entities)
        {
            await _entities.AddRangeAsync(entities);
            return entities;
        }

        public TEntity Update(TEntity entity)
        {
            _entities.Update(entity);
            return entity;
        }

        public IEnumerable<TEntity> UpdateRange(IList<TEntity> entities)
        {
            _entities.UpdateRange(entities);
            return entities;
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            if (entities.Any())
            {
                _entities.RemoveRange(entities);
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = Find(expression);

            if (entities.Any())
            {
                _entities.RemoveRange(entities);
            }
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await (expression is null ? _entities.FirstOrDefaultAsync() : _entities.FirstOrDefaultAsync(expression));
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await (expression is null ? _entities.AnyAsync() : _entities.AnyAsync(expression));
        }
    }
}