using Microsoft.Extensions.DependencyInjection;
using ToyFiledbBackup.App.Services.Initialize;

var serviceProvider = new AppServiceProviderFactory().Factory();
var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

using (var serviceScope = serviceScopeFactory.CreateScope()) 
{
    var initDatabaseService = serviceScope.ServiceProvider.GetRequiredService<IInitDatabaseService>();
    await initDatabaseService.InitDatabaseAsync();
}

