using Microsoft.EntityFrameworkCore;
using ToyFiledbbackup.Infrastructure.SchemaDefinitions;
using ToyFiledbBackup.Domain.Entities;
using ToyFiledbBackup.Domain.Repositories;

namespace ToyFiledbbackup.Infrastructure.Contexts
{
    public class SampleDbContext : DbContext, IUnitOfWork
    {
        public DbSet<SampleSystemLog>? SampleSystemLogs { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SampleSystemLogEntitySchemaDefinition());
        }

        #region IUnitOfWork
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            int affected = await SaveChangesAsync(cancellationToken);
            return affected > 0; // if affected more than one.
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public int SaveChanges(CancellationToken cancellationToken = default)
        {
            return base.SaveChanges();
        }
        #endregion
    }
}