using System;
using Volo.Abp.Application.Dtos;

namespace App.SoftPOS.MTIs
{
    public class MTIDto : FullAuditedEntityDto<Guid>
    {
        public string MTI_Code_Req { get; set; }
        public string MTI_Code_Resp { get; set; }
        public string? Download_Code { get; set; }
        public string? Response_Code { get; set; }
    }
}