using SampleProject.Business.Abstractions;
using SampleProject.Data.UnitOfWork;
using SampleProject.Service.Abstractions;
using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Requests;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses;
using SampleProject.Shared.Responses.AAColumnAliases;

namespace SampleProject.Business.Implements
{
    public class AAColumnAliasBusiness : BusinessBase, IAAColumnAliasBusiness
    {
        private readonly IAAColumnAliasService _aAColumnAliasService;

        public AAColumnAliasBusiness(IUnitOfWorkService unitOfWorkService,
            IAAColumnAliasService aAColumnAliasService,
            ICoreProvider coreProvider) : base(unitOfWorkService, coreProvider)
        {
            _aAColumnAliasService = aAColumnAliasService;
        }

        public async Task Delete(int id)
        {
            await _aAColumnAliasService.DeleteSP(id);
        }

        public async Task<PagedResult<AAColumnAliasResponse>> GetAll(BaseGetAllRequest request)
        {
            return await _aAColumnAliasService.GetAllPagingAsync(request);
        }

        public async Task<AAColumnAliasResponse> GetByIdSP(int id)
        {
            return await _aAColumnAliasService.GetByIdSP(id);
        }

        public async Task<AAColumnAliasResponse> Insert(AAColumnAliasRequest request)
        {
            var entity = await _aAColumnAliasService.InsertAsync(request);
            await _unitOfWorkService.SaveChangesAsync();
            return _mapper.Map<AAColumnAliasResponse>(entity);
        }

        public async Task<AAColumnAliasResponse> Update(UpdateAAColumnAliasRequest request)
        {
            var entity = await _aAColumnAliasService.UpdateAsync(request, request.AAColumnAliasID);
            await _unitOfWorkService.SaveChangesAsync();
            return _mapper.Map<AAColumnAliasResponse>(entity);
        }
    }
}
