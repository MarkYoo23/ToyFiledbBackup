using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyFiledbBackup.Domain.Entities;

namespace ToyFiledbbackup.Infrastructure.SchemaDefinitions
{
    public class SampleSystemLogEntitySchemaDefinition : IEntityTypeConfiguration<SampleSystemLog>
    {
        public void Configure(EntityTypeBuilder<SampleSystemLog> builder)
        {
            builder.HasKey(column => column.Id);
        }
    }
}
