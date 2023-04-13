using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.RetailerDatas
{
    public class RD_Seg02Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string AddressArabic01 { get; set; }
        public string AddressEnglish01 { get; set; }

    }
}
