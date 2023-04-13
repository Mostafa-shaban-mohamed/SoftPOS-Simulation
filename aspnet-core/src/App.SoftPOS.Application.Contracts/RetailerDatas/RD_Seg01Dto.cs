using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.RetailerDatas
{
    public class RD_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string NextLoad { get; set; }
        public string ReconciliationTime { get; set; }
        public string ArabicName { get; set; }
        public string EnglishNumber { get; set; }
        public string EnglishName { get; set; }
        public string LanguageIndicator { get; set; }
        public string TerminalCurrencyCode { get; set; }
        public string TerminalCountryCode { get; set; }
        public string TransactionCurrencyExponent { get; set; }
        public string CurrencySymbolArabic { get; set; }
        public string CurrencySymbolEnglish { get; set; }
        public string ReceiptArabic01 { get; set; }
        public string ReceiptArabic02 { get; set; }
        public string ReceiptEnglish01 { get; set; }
        public string ReceiptEnglish02 { get; set; }
    }
}
