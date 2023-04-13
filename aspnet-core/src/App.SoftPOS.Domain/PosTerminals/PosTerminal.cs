using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.PosTerminals
{
    public class PosTerminal
    {
        [Required]
        public string Terminal_ID { get; set; }

        public string RetailerData_ID { get; set; }
        public string CardSchema_ID { get; set; }
        public string MessageText_ID { get; set; }
        public string PublicKey_ID { get; set; }
        public string TerminalConnection_ID { get; set; }
        public string DeviceSpecific_ID { get; set; }
        public string AIDList_ID { get; set; }
        public string AIDData_ID { get; set; }
        public string RevokeCertificates_ID { get; set; }
    }
}
