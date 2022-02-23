namespace ToyFiledbBackup.Domain.Repositories
{
    public interface ISampleBackupRepository
    {
        Task BackupAsync(string filePath);
    }
}
