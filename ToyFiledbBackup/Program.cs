using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using ToyFiledbBackup.App.Services.Initialize;
using ToyFiledbBackup.Domain.Entities;
using ToyFiledbBackup.Domain.Repositories;
using ToyFiledbBackup.Domain.Services;

var serviceProvider = new AppServiceProviderFactory().Factory();
var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

using (var serviceScope = serviceScopeFactory.CreateScope())
{
    var databaseInitService = serviceScope.ServiceProvider.GetRequiredService<IDatabaseInitService>();
    await databaseInitService.InitDatabaseAsync();

    var stopwatch = new Stopwatch();

    var sampleSystemLogRepository = serviceScope.ServiceProvider.GetRequiredService<ISampleSystemLogRepository>();
    for (var count = 0; count < 1000000; count++)
    {
        await sampleSystemLogRepository.AddAsync(new SampleSystemLog()
        {
            Content = "Test"
        });
    }
    await sampleSystemLogRepository.UnitOfWork.SaveChangeAsync();

    stopwatch.Start();
    var databaseBackupService = serviceScope.ServiceProvider.GetRequiredService<IDatabaseBackupService>();
    await databaseBackupService.BackupAsync();
    stopwatch.Stop();
    Console.WriteLine($"The time it took to back up the file : {stopwatch.ElapsedMilliseconds}ms");

}