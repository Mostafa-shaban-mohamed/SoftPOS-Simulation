using App.SoftPOS.AIDDatas;
using App.SoftPOS.AIDLists;
using App.SoftPOS.CardSchemas;
using App.SoftPOS.Categories;
using App.SoftPOS.DeviceSpecifics;
using App.SoftPOS.MessageTexts;
using App.SoftPOS.PosTerminals;
using App.SoftPOS.PublicKeys;
using App.SoftPOS.RetailerDatas;
using App.SoftPOS.RevokeCertificates;
using App.SoftPOS.TerminalConnections;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace App.SoftPOS
{
    public interface ISegmentAppService : ICrudAppService<RD_Seg01Dto, string>, ICrudAppService<RD_Seg02Dto, string>, ICrudAppService<RD_Seg03Dto, string>, ICrudAppService<RD_Seg04Dto, string>
        , ICrudAppService<CS_Seg01Dto, string>, ICrudAppService<CS_Seg02Dto, string>, ICrudAppService<CS_Seg03Dto, string>
        , ICrudAppService<MT_Seg01Dto, string>, ICrudAppService<PK_Seg01Dto, string>, ICrudAppService<TC_Seg01Dto, string>
        , ICrudAppService<DS_Seg01Dto, string>, ICrudAppService<AD_Seg01Dto, string>, ICrudAppService<AL_Seg01Dto, string>
        , ICrudAppService<RC_Seg01Dto, string>, ICrudAppService<PosTerminalDto, string>, ICrudAppService<CategoryDto, string>
    {
    }
}
