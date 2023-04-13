using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.MessageTexts
{
    public class MT_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string MessageCode { get; set; }
        public string DisplayCode { get; set; }
        public string MessageTextArabic { get; set; }
        public string MessageTextEnglish { get; set; }

    }
}
