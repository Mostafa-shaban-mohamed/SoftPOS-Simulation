using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.ISOMsgs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.SoftPOS
{
    public interface ImsgAppService : ICrudAppService<ISOMsgDto, Guid, PagedAndSortedResultRequestDto>
    {
        
    }
}