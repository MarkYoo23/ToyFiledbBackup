using ToyFiledbbackup.Infrastructure.Contexts;
using ToyFiledbBackup.Domain.Entities;
using ToyFiledbBackup.Domain.Repositories;

namespace ToyFiledbbackup.Infrastructure.Repositories
{
    public class SampleSystemLogRepository : ISampleSystemLogRepository
    {
        private readonly SampleDbContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public SampleSystemLogRepository(SampleDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SampleSystemLog log)
        {
            await _context.AddAsync(log);
        }

        public IEnumerable<SampleSystemLog> GetAllAsync(int id)
        {
            throw new NotImplementedException();
        }

        public SampleSystemLog GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(SampleSystemLog log)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SampleSystemLog log)
        {
            throw new NotImplementedException();
        }
    }
}
