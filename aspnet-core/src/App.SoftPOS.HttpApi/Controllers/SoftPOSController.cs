using App.SoftPOS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace App.SoftPOS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SoftPOSController : AbpControllerBase
{
    protected SoftPOSController()
    {
        LocalizationResource = typeof(SoftPOSResource);
    }
}
