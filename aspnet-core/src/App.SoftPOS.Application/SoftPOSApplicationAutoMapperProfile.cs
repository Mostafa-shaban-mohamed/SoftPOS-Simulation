using App.SoftPOS.DownloadParameters;
using App.SoftPOS.ISOMsgs;
using App.SoftPOS.MTIs;
using App.SoftPOS.MTIs.DownloadParameters;
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
    }
}
