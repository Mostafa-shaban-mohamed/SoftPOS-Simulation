using App.SoftPOS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace App.SoftPOS.Permissions;

public class SoftPOSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SoftPOSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SoftPOSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SoftPOSResource>(name);
    }
}
