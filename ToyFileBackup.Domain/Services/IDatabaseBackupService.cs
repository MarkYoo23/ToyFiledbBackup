namespace ToyFiledbBackup.Domain.Services
{
    public interface IDatabaseBackupService
    {
        Task BackupAsync();
    }
}
