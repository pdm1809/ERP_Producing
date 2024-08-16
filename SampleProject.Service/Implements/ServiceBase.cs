using AutoMapper;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data.Repositories.Abstractions;
using SampleProject.Service.Abstractions;
using SampleProject.Shared.Constants;
using SampleProject.Shared.Extensions;
using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Requests;
using SampleProject.Shared.Responses;
using SampleProject.Shared.Settings;
using System.Linq.Expressions;

namespace SampleProject.Service.Implements
{
    public abstract class ServiceBase<TEntity> : IService<TEntity>
        where TEntity : class
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly SampleProjectSetting _setting;
        protected readonly IMapper _mapper;
        protected readonly ICoreProvider _coreProvider;

        protected ServiceBase(IRepository<TEntity> repository,
            ICoreProvider coreProvider)
        {
            _repository = repository;
            _setting = coreProvider.Setting;
            _mapper = coreProvider.Mapper;
            _coreProvider = coreProvider;
        }

        public async Task<long> CountAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await _repository.CountAsync(expression);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> expression = null)
        {
            _repository.Delete(expression);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _repository.DeleteRange(entities);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression = null)
        {
            return _repository.Find(expression);
        }

        public async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await _repository.FindAsync(expression);
        }

        public async Task<List<TResponse>> FindAsync<TResponse>(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = await FindAsync(expression);
            return _mapper.Map<List<TResponse>>(entities);
        }

        public virtual async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await _repository.FirstOrDefaultAsync(expression);
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TEntity> entities)
        {
            return await _repository.InsertRangeAsync(entities.ToList());
        }

        public TEntity Update(TEntity entity)
        {
            return _repository.Update(entity);
        }

        public IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities)
        {
            return _repository.UpdateRange(entities.ToList());
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await _repository.AnyAsync(expression);
        }
    }

    public abstract class ServiceBase<TEntity, TResponse> : ServiceBase<TEntity>, IService<TEntity, TResponse>
        where TEntity : class
        where TResponse : class
    {
        protected ServiceBase(IRepository<TEntity> repository,
            ICoreProvider coreProvider) : base(repository, coreProvider)
        {
        }

        public async Task<List<TResponse>> FindResponseAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = await FindAsync(expression);
            return _mapper.Map<List<TResponse>>(entities);
        }

        public async Task<TResponse> FirstOrDefaultResponseAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            var entity = await FirstOrDefaultAsync(expression);
            return entity is null ? null : _mapper.Map<TResponse>(entity);
        }

        public async Task<TResponse> GetResponseByIdAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            return entity is null ? null : _mapper.Map<TResponse>(entity);
        }
    }

    public abstract class ServiceBase<TEntity, TRequest, TResponse> : ServiceBase<TEntity, TResponse>, IService<TEntity, TRequest, TResponse>
        where TEntity : class
        where TRequest : class
        where TResponse : class
    {
        protected ServiceBase(IRepository<TEntity> repository,
            ICoreProvider coreProvider) : base(repository, coreProvider)
        {
        }

        public Task<TEntity> InsertAsync(TRequest request, Action<TEntity> prepareInsert = null)
        {
            var entity = MapEntityForInsert(request);
            prepareInsert?.Invoke(entity);
            return InsertAsync(entity);
        }

        public Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TRequest> requests, Action<TEntity> prepareInsert = null)
        {
            var entities = requests.Select(x =>
            {
                var entity = MapEntityForInsert(x);
                prepareInsert?.Invoke(entity);
                return entity;
            });
            return InsertRangeAsync(entities);
        }

        public async Task<TEntity> UpdateAsync(TRequest request, object id)
        {
            var entity = await PrepareUpdateAsync(request, id);

            if (entity is not null)
            {
                entity = Update(entity);
            }

            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateRangeAsync(IDictionary<TRequest, object> requests)
        {
            IEnumerable<TEntity> entities = new List<TEntity>();

            foreach (var request in requests)
            {
                var entity = await PrepareUpdateAsync(request.Key, request.Value);

                if (entity is not null)
                {
                    (entities as List<TEntity>).Add(entity);
                }
            }

            if (entities.Any())
            {
                entities = UpdateRange(entities);
            }

            return entities;
        }

        protected virtual TEntity MapEntityForInsert(TRequest request)
        {
            return _mapper.Map<TEntity>(request);
        }

        protected virtual void MapEntityForUpdate(TRequest fromRequest, TEntity toEntity)
        {
            _mapper.Map(fromRequest, toEntity);
        }

        private async Task<TEntity> PrepareUpdateAsync(TRequest request, object id)
        {
            TEntity entity = null;

            if (id is not null)
            {
                entity = await GetByIdAsync(id);

                if (entity is not null)
                {
                    MapEntityForUpdate(request, entity);
                }
            }

            return entity;
        }
    }

    public abstract class GetAllServiceBase<TEntity, TGetAllRequest, TResponse> : ServiceBase<TEntity, TResponse>, IGetAllService<TEntity, TGetAllRequest, TResponse>
        where TEntity : class
        where TGetAllRequest : BaseGetAllRequest
        where TResponse : class
    {
        protected GetAllServiceBase(IRepository<TEntity> repository,
            ICoreProvider coreProvider) : base(repository, coreProvider)
        {
        }

        public async Task<IEnumerable<TResponse>> GetAllAsync(TGetAllRequest getAllRequest)
        {
            var entities = await GetAll(getAllRequest, Find, GetFilterExpressionForGetAll, ApplyOrderByForGetAll, ApplyIncludeForGetAll).ToListAsync();
            return _mapper.Map<IEnumerable<TResponse>>(entities);
        }

        public async Task<PagedResult<TResponse>> GetAllPagingAsync(TGetAllRequest getAllRequest)
        {
            return await GetAllPagingAsync(_mapper, getAllRequest, Find, GetFilterExpressionForGetAll, ApplyOrderByForGetAll, ApplyIncludeForGetAll);
        }

        protected virtual IQueryable<TEntity> ApplyIncludeForGetAll(IQueryable<TEntity> entities) => entities;

        protected virtual IQueryable<TEntity> ApplyOrderByForGetAll(IQueryable<TEntity> entities, TGetAllRequest getAllRequest)
            => BaseApplyOrderByForGetAll(entities, getAllRequest);

        protected virtual Expression<Func<TEntity, bool>> GetFilterExpressionForGetAll(TGetAllRequest request)
            => BaseGetFilterExpressionForGetAll(request);

        internal static IQueryable<TEntity> BaseApplyOrderByForGetAll(IQueryable<TEntity> entities, TGetAllRequest getAllRequest)
        {
            if (!string.IsNullOrEmpty(getAllRequest.SortField))
            {
                entities = entities.OrderByDynamic(getAllRequest.SortField, getAllRequest.Asc ?? true);
            }

            return entities;
        }

        internal static Expression<Func<TEntity, bool>> BaseGetFilterExpressionForGetAll(TGetAllRequest request)
        {
            return PredicateBuilder.New<TEntity>(entity => true);
        }

        internal async static Task<PagedResult<TResponse>> GetAllPagingAsync(IMapper mapper, TGetAllRequest getAllRequest, Func<Expression<Func<TEntity, bool>>, IQueryable<TEntity>> queryFunc = null,
            Func<TGetAllRequest, Expression<Func<TEntity, bool>>> getFilterExpressionFunc = null, Func<IQueryable<TEntity>, TGetAllRequest, IQueryable<TEntity>> applyOrderByFunc = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> applyIncludeFunc = null)
        {
            var query = GetAll(getAllRequest, queryFunc, getFilterExpressionFunc, applyOrderByFunc);
            var count = await query.CountAsync();
            var pageSize = getAllRequest.PageSize ?? Common.PageSizeMin;
            pageSize = Math.Min(pageSize, Common.PageSizeMax);
            pageSize = Math.Max(pageSize, Common.PageSizeMin);
            var pageIndex = Math.Max(getAllRequest.PageIndex, 0);
            query = query.Skip(pageSize * pageIndex).Take(pageSize);
            var entities = await applyIncludeFunc.Invoke(query).ToListAsync();
            return new PagedResult<TResponse>()
            {
                Results = mapper.Map<IList<TResponse>>(entities),
                CurrentPage = pageIndex,
                RowCount = count,
                PageSize = pageSize
            };
        }

        internal static IQueryable<TEntity> GetAll(TGetAllRequest getAllRequest, Func<Expression<Func<TEntity, bool>>, IQueryable<TEntity>> queryFunc = null,
            Func<TGetAllRequest, Expression<Func<TEntity, bool>>> getFilterExpressionFunc = null, Func<IQueryable<TEntity>, TGetAllRequest, IQueryable<TEntity>> applyOrderByFunc = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> applyIncludeFunc = null)
        {
            var query = queryFunc.Invoke(null)
                .Where(getFilterExpressionFunc.Invoke(getAllRequest));
            query = applyOrderByFunc.Invoke(query, getAllRequest);

            if (applyIncludeFunc is not null)
            {
                query = applyIncludeFunc.Invoke(query);
            }

            return query;
        }
    }

    public abstract class ServiceBase<TEntity, TRequest, TResponse, TGetAllRequest> : ServiceBase<TEntity, TRequest, TResponse>, IService<TEntity, TRequest, TResponse, TGetAllRequest>
        where TEntity : class
        where TGetAllRequest : BaseGetAllRequest
        where TRequest : class
        where TResponse : class
    {
        protected ServiceBase(IRepository<TEntity> repository,
            ICoreProvider coreProvider) : base(repository, coreProvider)
        {
        }

        public async Task<IEnumerable<TResponse>> GetAllAsync(TGetAllRequest getAllRequest)
        {
            var entities = await GetAllServiceBase<TEntity, TGetAllRequest, TResponse>.GetAll(getAllRequest, Find, GetFilterExpressionForGetAll, ApplyOrderByForGetAll, ApplyIncludeForGetAll).ToListAsync();
            return _mapper.Map<IEnumerable<TResponse>>(entities);
        }

        public async Task<PagedResult<TResponse>> GetAllPagingAsync(TGetAllRequest getAllRequest)
        {
            return await GetAllServiceBase<TEntity, TGetAllRequest, TResponse>.GetAllPagingAsync(_mapper, getAllRequest, Find, GetFilterExpressionForGetAll, ApplyOrderByForGetAll, ApplyIncludeForGetAll);
        }

        protected virtual IQueryable<TEntity> ApplyIncludeForGetAll(IQueryable<TEntity> entities) => entities;

        protected virtual IQueryable<TEntity> ApplyOrderByForGetAll(IQueryable<TEntity> entities, TGetAllRequest getAllRequest)
            => GetAllServiceBase<TEntity, TGetAllRequest, TResponse>.BaseApplyOrderByForGetAll(entities, getAllRequest);

        protected virtual Expression<Func<TEntity, bool>> GetFilterExpressionForGetAll(TGetAllRequest request)
            => GetAllServiceBase<TEntity, TGetAllRequest, TResponse>.BaseGetFilterExpressionForGetAll(request);
    }
}
