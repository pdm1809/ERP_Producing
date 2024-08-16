using SampleProject.Shared.Requests;
using SampleProject.Shared.Responses;
using System.Linq.Expressions;

namespace SampleProject.Service.Abstractions
{
    public interface IService<TEntity>
    {
        Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression = null);
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> expression = null);
        void Delete(TEntity entity);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression = null);
        IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities);
        Task<long> CountAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null);
    }

    public interface IService<TEntity, TResponse> : IService<TEntity>
    {
        Task<TResponse> GetResponseByIdAsync(string id);
        Task<TResponse> FirstOrDefaultResponseAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<List<TResponse>> FindResponseAsync(Expression<Func<TEntity, bool>> expression = null);
    }

    public interface IService<TEntity, TRequest, TResponse> : IService<TEntity, TResponse>
        where TRequest : class
    {
        Task<TEntity> InsertAsync(TRequest request, Action<TEntity> prepareInsert = null);
        Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TRequest> requests, Action<TEntity> prepareInsert = null);
        Task<TEntity> UpdateAsync(TRequest request, object id);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IDictionary<TRequest, object> requests);
    }

    public interface IGetAllService<TEntity, TGetAllRequest, TResponse> : IService<TEntity, TResponse>
        where TGetAllRequest : BaseGetAllRequest
        where TResponse : class
    {
        Task<IEnumerable<TResponse>> GetAllAsync(TGetAllRequest getAllRequest);
        Task<PagedResult<TResponse>> GetAllPagingAsync(TGetAllRequest getAllRequest);
    }

    public interface IService<TEntity, TRequest, TResponse, TGetAllRequest> : IService<TEntity, TRequest, TResponse>,
        IGetAllService<TEntity, TGetAllRequest, TResponse>
        where TGetAllRequest : BaseGetAllRequest
        where TRequest : class
        where TResponse : class
    {
    }
}
