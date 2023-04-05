using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.SoftPOS.MTIs
{
    public class MTIRequestDto
    {
        public string MTI_Code_Req { get; set; }
        public string? Download_Code { get; set; }
    }
}