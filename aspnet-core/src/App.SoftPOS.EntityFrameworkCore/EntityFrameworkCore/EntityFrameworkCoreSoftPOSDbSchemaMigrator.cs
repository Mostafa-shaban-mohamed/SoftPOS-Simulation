using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using App.SoftPOS.Data;
using Volo.Abp.DependencyInjection;

namespace App.SoftPOS.EntityFrameworkCore;

public class EntityFrameworkCoreSoftPOSDbSchemaMigrator
    : ISoftPOSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSoftPOSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SoftPOSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SoftPOSDbContext>()
            .Database
            .MigrateAsync();
    }
}
