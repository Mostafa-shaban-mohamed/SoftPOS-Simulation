using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.MTIs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.SoftPOS
{
    public interface IMTIAppService : ICrudAppService<MTIDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMTIDto, MTIResponseDto>, IApplicationService
    {
        
    }
}