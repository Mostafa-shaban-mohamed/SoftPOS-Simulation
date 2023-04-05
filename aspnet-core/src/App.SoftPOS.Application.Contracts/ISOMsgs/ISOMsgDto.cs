using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.SoftPOS.ISOMsgs
{
    public class ISOMsgDto :  EntityDto<Guid>
    {
        public string BufferMsg { get; set; }
    }
}