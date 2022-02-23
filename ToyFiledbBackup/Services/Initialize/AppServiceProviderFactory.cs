using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToyFiledbbackup.Infrastructure.Contexts;
using ToyFiledbbackup.Infrastructure.Repositories;
using ToyFiledbBackup.Domain.Repositories;

namespace ToyFiledbBackup.App.Services.Initialize
{
    public class AppServiceProviderFactory
    {
        public IServiceProvider Factory() 
        {
            var serviceCollection = new ServiceCollection();

            var sampleDbPath = $"Data Source = {Path.Combine(AppContext.BaseDirectory, "./Sample.db")}";
            serviceCollection.AddDbContext<SampleDbContext>(option => option.UseSqlite(sampleDbPath));

            serviceCollection.AddScoped<ISampleSystemLogRepository, SampleSystemLogRepository>();
            serviceCollection.AddScoped<IInitDatabaseService, InitDatabaseService>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
