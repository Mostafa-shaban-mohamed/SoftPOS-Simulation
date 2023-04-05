using Volo.Abp.Modularity;

namespace App.SoftPOS;

[DependsOn(
    typeof(SoftPOSApplicationModule),
    typeof(SoftPOSDomainTestModule)
    )]
public class SoftPOSApplicationTestModule : AbpModule
{

}
