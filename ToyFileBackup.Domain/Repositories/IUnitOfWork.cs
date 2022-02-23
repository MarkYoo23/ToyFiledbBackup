﻿namespace ToyFiledbBackup.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
        int SaveChanges(CancellationToken cancellationToken = default(CancellationToken));
    }
}
