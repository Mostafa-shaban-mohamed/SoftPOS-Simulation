using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.SoftPOS.MTIs
{
    public class MTIResponseDto
    {
        public string MTI_Code_Resp { get; set; }
        public string? Response_Code { get; set; }
    }
}