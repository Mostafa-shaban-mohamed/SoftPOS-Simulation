using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.CardSchemas
{
    public class CS_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string CardSchemeID { get; set; }
        public string CardSchemeNameArabic { get; set; }
        public string CardSchemeNameEnglish { get; set; }
        public string CardSchemeAcquirerID { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string MerchantID { get; set; }
        public string TerminalID { get; set; }
        public string EnableEMV { get; set; }
        public string CheckServiceCode { get; set; }
        public string OfflineRefundAuthorization { get; set; }


    }
}
