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

        public void AddAsync(SampleSystemLog log)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SampleSystemLog> GetAllAsync(int id)
        {
            throw new NotImplementedException();
        }

        public SampleSystemLog GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(SampleSystemLog log)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(SampleSystemLog log)
        {
            throw new NotImplementedException();
        }
    }
}
