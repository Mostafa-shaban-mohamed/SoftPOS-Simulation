using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace App.SoftPOS.RetailerDatas
{
    public interface IRetailerData01 : IApplicationService, ICrudAppService<RD_Seg01Dto, string>
    {
    }
}
