using SampleProject.Shared.Requests;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses;
using SampleProject.Shared.Responses.AAColumnAliases;

namespace SampleProject.Business.Abstractions
{
    public interface IAAColumnAliasBusiness : IBusiness
    {
        Task<AAColumnAliasResponse> GetByIdSP(int id);
        Task<PagedResult<AAColumnAliasResponse>> GetAll(BaseGetAllRequest request);
        Task<AAColumnAliasResponse> Insert(AAColumnAliasRequest request);
        Task<AAColumnAliasResponse> Update(UpdateAAColumnAliasRequest request);
        Task Delete(int id);
    }
}
