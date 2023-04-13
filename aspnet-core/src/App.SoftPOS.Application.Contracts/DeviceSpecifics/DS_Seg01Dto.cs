using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.DeviceSpecifics
{
    public class DS_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string Data { get; set; }
        public string CardScheme01 { get; set; }
        public string TerminalContactlessTransactionLimit01 { get; set; }
        public string TerminalCVMRequiredLimit01 { get; set; }
        public string TerminalContactlessFloorLimit01 { get; set; }
        public string CardScheme02 { get; set; }
        public string TerminalContactlessTransactionLimit02 { get; set; }
        public string TerminalCVMRequiredLimit02 { get; set; }
        public string TerminalContactlessFloorLimit02 { get; set; }
        public string CardScheme03 { get; set; }
        public string TerminalContactlessTransactionLimit03 { get; set; }
        public string TerminalCVMRequiredLimit03 { get; set; }
        public string TerminalContactlessFloorLimit03 { get; set; }
        public string MaxSAFDepth { get; set; }
        public string MaxSAFCumualtiveAmount { get; set; }
        public string IdleTime { get; set; }
        public string MaxReconciliationAmount { get; set; }
        public string MaxTransactionsProcessed { get; set; }
        public string QRCodePrintIndicator { get; set; }

    }
}
