using Microsoft.Data.Sqlite;
using ToyFiledbBackup.Domain.Repositories;

namespace ToyFiledbbackup.Infrastructure.Repositories
{
    public class SampleBackupRepository : ISampleBackupRepository
    {
        private readonly SqliteConnection _sqliteConnection;

        public SampleBackupRepository(string dataSoruce)
        {
            _sqliteConnection = new SqliteConnection(dataSoruce);
            _sqliteConnection.Open();
        }

        public async Task BackupAsync(string filePath)
        {
            await Task.Run(async () =>
            {
                var sqliteConnection = new SqliteConnection($"Data Source={filePath}");
                await sqliteConnection.OpenAsync();
                _sqliteConnection.BackupDatabase(sqliteConnection);
            });
        }
    }
}
