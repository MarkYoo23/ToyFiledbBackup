using ToyFiledbBackup.Domain.Entities;

namespace ToyFiledbBackup.Domain.Repositories
{
    public interface ISampleSystemLogRepository : IRepository
    {
        SampleSystemLog GetAsync(int id);
        IEnumerable<SampleSystemLog> GetAllAsync(int id);

        Task AddAsync(SampleSystemLog log);
        Task UpdateAsync(SampleSystemLog log);
        Task RemoveAsync(SampleSystemLog log);
    }
}
