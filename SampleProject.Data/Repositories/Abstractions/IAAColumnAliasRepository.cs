using SampleProject.Data.Models;

namespace SampleProject.Data.Repositories.Abstractions
{
    public interface IAAColumnAliasRepository : IRepository<AacolumnAlias>
    {
        Task<AacolumnAlias> GetByIdSP(int id);
        Task DeleteSP(int id);
    }
}
