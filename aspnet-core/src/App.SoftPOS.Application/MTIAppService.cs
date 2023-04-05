using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.MTIs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.SoftPOS
{
    public class MTIAppService : CrudAppService<MTI, MTIDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMTIDto, MTIResponseDto>, IMTIAppService
    {
        private readonly IRepository<MTI, Guid> _MtiRepo;
        public MTIAppService(IRepository<MTI, Guid> repository): base(repository)
        {
            _MtiRepo = repository;
            // GetPolicyName = SourceCodePermissions.Types.Default;
            // GetListPolicyName = SourceCodePermissions.Types.Default;
            // CreatePolicyName = SourceCodePermissions.Types.Create;
            // UpdatePolicyName = SourceCodePermissions.Types.Update;
            // DeletePolicyName = SourceCodePermissions.Types.Delete;
        }

        public async Task<MTIResponseDto> PostResponse(MTIRequestDto requestDto)
        {
            var mti = await _MtiRepo.FirstOrDefaultAsync
                (m => m.MTI_Code_Req == requestDto.MTI_Code_Req && m.Download_Code == requestDto.Download_Code);
            var mtiDto = ObjectMapper.Map<MTI, MTIResponseDto>(mti);
            return mtiDto;
        }
    }
}