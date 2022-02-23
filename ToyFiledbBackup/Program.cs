using Microsoft.Extensions.DependencyInjection;
using ToyFiledbBackup.App.Services.Initialize;
using ToyFiledbBackup.Domain.Services;

var serviceProvider = new AppServiceProviderFactory().Factory();
var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

using (var serviceScope = serviceScopeFactory.CreateScope()) 
{
    var databaseInitService = serviceScope.ServiceProvider.GetRequiredService<IDatabaseInitService>();
    await databaseInitService.InitDatabaseAsync();

    var databaseBackupService = serviceScope.ServiceProvider.GetRequiredService<IDatabaseBackupService>();
    await databaseBackupService.BackupAsync();
}