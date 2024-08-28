using Microsoft.EntityFrameworkCore;
using SampleProject.Data.Contexts;
using SampleProject.Data.Models;
using SampleProject.Data.Repositories.Abstractions;
using SampleProject.Shared.Providers.Abstractions;

namespace SampleProject.Data.Repositories.Implements
{
    public class AAColumnAliasRepository : RepositoryBase<AacolumnAlias>, IAAColumnAliasRepository
    {
        public AAColumnAliasRepository(SampleDbContext dbContext, ICoreProvider coreProvider) : base(dbContext, coreProvider)
        {
        }

        public async Task DeleteSP(int id)
        {
            await _database.ExecuteSqlRawAsync("EXECUTE [dbo].[AAColumnAlias_Delete] {0}", id);
        }

        public async Task<AacolumnAlias> GetByIdSP(int id)
        {
            var entities = await _entities.FromSqlRaw("EXECUTE [dbo].[AAColumnAlias_Select] {0}", id).ToListAsync();
            return entities.FirstOrDefault();
        }
    }
}
