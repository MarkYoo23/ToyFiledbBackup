using ToyFiledbBackup.Domain.Entities;

namespace ToyFiledbBackup.Domain.Repositories
{
    public interface ISampleSystemLogRepository : IRepository
    {
        SampleSystemLog GetAsync(int id);
        IEnumerable<SampleSystemLog> GetAllAsync(int id);

        void AddAsync(SampleSystemLog log);
        void UpdateAsync(SampleSystemLog log);
        void RemoveAsync(SampleSystemLog log);
    }
}
