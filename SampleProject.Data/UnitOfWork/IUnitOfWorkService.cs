namespace SampleProject.Data.UnitOfWork
{
    public interface IUnitOfWorkService
    {
        Task SaveChangesAsync();
    }
}
