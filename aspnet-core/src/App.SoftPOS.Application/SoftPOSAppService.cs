using System;
using System.Collections.Generic;
using System.Text;
using App.SoftPOS.Localization;
using Volo.Abp.Application.Services;

namespace App.SoftPOS;

/* Inherit your application services from this class.
 */
public abstract class SoftPOSAppService : ApplicationService
{
    protected SoftPOSAppService()
    {
        LocalizationResource = typeof(SoftPOSResource);
    }
}
