using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace App.SoftPOS.Data;

/* This is used if database provider does't define
 * ISoftPOSDbSchemaMigrator implementation.
 */
public class NullSoftPOSDbSchemaMigrator : ISoftPOSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
