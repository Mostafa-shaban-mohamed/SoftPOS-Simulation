using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace App.SoftPOS;

[Dependency(ReplaceServices = true)]
public class SoftPOSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SoftPOS";
}
