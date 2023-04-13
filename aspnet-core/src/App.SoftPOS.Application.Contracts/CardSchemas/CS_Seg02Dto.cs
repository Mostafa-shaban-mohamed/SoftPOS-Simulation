using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.CardSchemas
{
    public class CS_Seg02Dto
    {
        //FK
        public string Category_ID { get; set; }
       
        public string Segment_ID { get; set; }
        public string CardSchemeID { get; set; }
        public string TransactionsAllowed { get; set; }
        public string CardholderAuthentication { get; set; }
        public string SupervisorFunctions { get; set; }
        public string ManualEntryAllowed { get; set; }
        public string FloorlimitIndicator { get; set; }
        public string TerminalFloorLimit { get; set; }
        public string TerminalFloorLimitFallBack { get; set; }
        public string MaxCashBack { get; set; }
        public string MaxTransactionAmountIndicator { get; set; }
        public string MaxAmountAllowed { get; set; }
        public string LuhnCheck { get; set; }
        public string ExpiryDatePosition { get; set; }
        public string DelayCallSetUp { get; set; }
    }
}
