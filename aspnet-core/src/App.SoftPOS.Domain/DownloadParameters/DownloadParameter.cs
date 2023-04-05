using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace App.SoftPOS.DownloadParameters
{
    public class DownloadParameter :  FullAuditedEntity<Guid>
    {
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public string RecordNumber { get; set; }
    }
}