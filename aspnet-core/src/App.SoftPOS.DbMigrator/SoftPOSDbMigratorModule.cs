using App.SoftPOS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace App.SoftPOS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SoftPOSEntityFrameworkCoreModule),
    typeof(SoftPOSApplicationContractsModule)
    )]
public class SoftPOSDbMigratorModule : AbpModule
{

}
