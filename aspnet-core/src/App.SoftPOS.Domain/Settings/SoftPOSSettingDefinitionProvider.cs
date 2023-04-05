using Volo.Abp.Settings;

namespace App.SoftPOS.Settings;

public class SoftPOSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SoftPOSSettings.MySetting1));
    }
}
