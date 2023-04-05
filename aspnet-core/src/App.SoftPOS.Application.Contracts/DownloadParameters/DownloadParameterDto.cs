using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.SoftPOS.MTIs.DownloadParameters
{
    public class DownloadParameterDto :  AuditedEntityDto<Guid>
    {
        public string RecordNumber { get; set; }
    }
}