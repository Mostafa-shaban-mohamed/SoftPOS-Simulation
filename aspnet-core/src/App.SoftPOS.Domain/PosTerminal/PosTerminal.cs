using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.PosTerminal
{
    public class PosTerminal
    {
        public string Terminal_ID { get; set; }
        public string RetailerData_ID { get; set; }
        public string CardSchema_ID { get; set; }
        public string MessageText_ID { get; set; }
        public string PublicKey_ID { get; set; }
        public string TerminalConnection_ID { get; set; }
        public string DeviceSpecfic_ID { get; set; }
        public string AIDList_ID { get; set; }
        public string AIDData_ID { get; set; }
        public string RevokeCertificates_ID { get; set; }
    }
}
