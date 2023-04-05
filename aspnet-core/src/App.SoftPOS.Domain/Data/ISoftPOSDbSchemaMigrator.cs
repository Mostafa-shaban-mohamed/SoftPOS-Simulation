using System.Threading.Tasks;

namespace App.SoftPOS.Data;

public interface ISoftPOSDbSchemaMigrator
{
    Task MigrateAsync();
}
