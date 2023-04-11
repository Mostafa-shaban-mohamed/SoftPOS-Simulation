using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.RetailerDatas
{
    public class RD_Seg04
    {
        public string Segment_ID { get; set; }
        public string TerminalCapability { get; set; }
        public string AdditionalTerminalCapability { get; set; }
        public string DownloadPhoneNumber { get; set; }
        public string EMVTerminalType { get; set; }
        public string AutomicLoad { get; set; }
        public string SAFRetryLimit { get; set; }
        public string SAFDefaultMessageTransmissionNumber { get; set; }
    }
}
