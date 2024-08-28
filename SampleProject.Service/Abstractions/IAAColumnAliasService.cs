using SampleProject.Data.Models;
using SampleProject.Shared.Requests;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses.AAColumnAliases;

namespace SampleProject.Service.Abstractions
{
    public interface IAAColumnAliasService : IService<AacolumnAlias, AAColumnAliasRequest, AAColumnAliasResponse, BaseGetAllRequest>
    {
        Task<AAColumnAliasResponse> GetByIdSP(int id);
        Task DeleteSP(int id);
    }
}
