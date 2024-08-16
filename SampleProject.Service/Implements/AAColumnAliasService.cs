using SampleProject.Data.Models;
using SampleProject.Data.Repositories.Abstractions;
using SampleProject.Service.Abstractions;
using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Requests;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses.AAColumnAliases;

namespace SampleProject.Service.Implements
{
    public class AAColumnAliasService : ServiceBase<AacolumnAlias, AAColumnAliasRequest, AAColumnAliasResponse, BaseGetAllRequest>, IAAColumnAliasService
    {
        private readonly IAAColumnAliasRepository _aAColumnAliasRepository;

        public AAColumnAliasService(IAAColumnAliasRepository aAColumnAliasRepository, ICoreProvider coreProvider) : base(aAColumnAliasRepository, coreProvider)
        {
            _aAColumnAliasRepository = aAColumnAliasRepository;
        }

        public async Task DeleteSP(int id)
        {
            await _aAColumnAliasRepository.DeleteSP(id);
        }

        public async Task<AAColumnAliasResponse> GetByIdSP(int id)
        {
            return _mapper.Map<AAColumnAliasResponse>(await _aAColumnAliasRepository.GetByIdSP(id));
        }
    }
}
