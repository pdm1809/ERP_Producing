using Microsoft.EntityFrameworkCore;
using SampleProject.Data.Contexts;

namespace SampleProject.Data.UnitOfWork
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly DbContext _dbContext;

        public UnitOfWorkService(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync() => await SaveChangesAsync(_dbContext);

        private async Task SaveChangesAsync<T>(T dbContext) where T : DbContext
        {
            await dbContext.SaveChangesAsync()
                .ConfigureAwait(false);
        }
    }
}
