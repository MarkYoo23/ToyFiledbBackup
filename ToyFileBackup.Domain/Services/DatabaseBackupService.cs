using ToyFiledbBackup.Domain.Repositories;

namespace ToyFiledbBackup.Domain.Services
{
    public class DatabaseBackupService : IDatabaseBackupService
    {
        private readonly ISampleBackupRepository _sampleBackupRepository;

        public DatabaseBackupService(ISampleBackupRepository sampleBackupRepository)
        {
            _sampleBackupRepository = sampleBackupRepository;
        }

        public async Task BackupAsync()
        {
            var currentDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            var fileName = $"./Sample_{currentDate}.db";
            var fileFullPath = Path.Combine(AppContext.BaseDirectory, fileName);
            await _sampleBackupRepository.BackupAsync(fileFullPath);
        }
    }
}
