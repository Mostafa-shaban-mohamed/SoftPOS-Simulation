using App.SoftPOS.AIDDatas;
using App.SoftPOS.AIDLists;
using App.SoftPOS.CardSchemas;
using App.SoftPOS.Categories;
using App.SoftPOS.DeviceSpecifics;
using App.SoftPOS.DownloadParameters;
using App.SoftPOS.ISOMsgs;
using App.SoftPOS.MessageTexts;
using App.SoftPOS.MTIs;
using App.SoftPOS.MTIs.DownloadParameters;
using App.SoftPOS.PosTerminals;
using App.SoftPOS.PublicKeys;
using App.SoftPOS.RetailerDatas;
using App.SoftPOS.RevokeCertificates;
using App.SoftPOS.TerminalConnections;
using AutoMapper;

namespace App.SoftPOS;

public class SoftPOSApplicationAutoMapperProfile : Profile
{
    public SoftPOSApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //MTI 
        CreateMap<MTI, MTIDto>(); //TSource, TDestination
        CreateMap<MTI, MTIResponseDto>();
        
        CreateMap<CreateUpdateMTIDto, MTI>();
        CreateMap<MTIRequestDto, MTI>();

        //Download Parameters
        CreateMap<DownloadParameter, DownloadParameterDto>(); //TSource, TDestination

        //Msg
        CreateMap<ISOMsg, ISOMsgDto>(); //TSource, TDestination
        CreateMap<ISOMsgDto, ISOMsg>();

        // --- Segments ---
        //Pos Terminal
        CreateMap<PosTerminalDto, PosTerminal>(); //TSource, TDestination
        //Category
        CreateMap<CategoryDto, Category>();
        //Retailer Data
        CreateMap<RD_Seg01Dto, RD_Seg01>();
        CreateMap<RD_Seg02Dto, RD_Seg02>();
        CreateMap<RD_Seg03Dto, RD_Seg03>();
        CreateMap<RD_Seg04Dto, RD_Seg04>();
        //Card Scheme
        CreateMap<CS_Seg01Dto, CS_Seg01>();
        //Message Text
        CreateMap<MT_Seg01Dto, MT_Seg01>();
        //Public Keys
        CreateMap<PK_Seg01Dto, PK_Seg01>();
        //Terminal Connection
        CreateMap<TC_Seg01Dto, TC_Seg01>();
        //Device Specific
        CreateMap<DS_Seg01Dto, DS_Seg01>();
        //AID List
        CreateMap<AL_Seg01Dto, AL_Seg01>();
        //AID Data
        CreateMap<AD_Seg01Dto, AD_Seg01>();
        //Revoke Certificate
        CreateMap<RC_Seg01Dto, RC_Seg01>();
    }
}
