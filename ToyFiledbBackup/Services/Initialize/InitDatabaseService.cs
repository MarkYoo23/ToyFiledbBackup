using ToyFiledbbackup.Infrastructure.Contexts;

namespace ToyFiledbBackup.App.Services.Initialize
{
    public class InitDatabaseService : IInitDatabaseService
    {
        private readonly SampleDbContext _context;

        public InitDatabaseService(SampleDbContext context)
        {
            _context = context;
        }

        public async Task InitDatabaseAsync()
        {
            var canConnnectDatabase = await _context.Database.CanConnectAsync();
            if (canConnnectDatabase) 
            {
                await _context.Database.EnsureDeletedAsync();
            }

            await _context.Database.EnsureCreatedAsync();
        }
    }
}
