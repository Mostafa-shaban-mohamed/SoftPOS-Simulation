using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.SoftPOS.MTIs
{
    public class CreateUpdateMTIDto : FullAuditedEntityDto<Guid>
    {
        [Required]
        public string MTI_Code_Req { get; set; }
        public string MTI_Code_Resp { get; set; }
        public string? Download_Code { get; set; }
        public string? Response_Code { get; set; }
    }
}