using App.SoftPOS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace App.SoftPOS;

[DependsOn(
    typeof(SoftPOSEntityFrameworkCoreTestModule)
    )]
public class SoftPOSDomainTestModule : AbpModule
{

}
