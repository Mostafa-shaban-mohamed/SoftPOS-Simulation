using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.TerminalConnections
{
    public class TC_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string Priority { get; set; }
        public string CommunicationType { get; set; }
        public string ResponseTimeout { get; set; }

        //Telecom Cable & GSM
        public string PhoneNumber { get; set; }
        public string DialAttemptToPhone { get; set; }
        public string ConnectTimeForPhone { get; set; }
        public string BaudRate { get; set; }
        public string ParityRate { get; set; }
        public string DataRate { get; set; }
        public string StopRate { get; set; }

        //TCP/IP & GPRS
        public string NetworkIPAddress { get; set; }
        public string NetworkTCPport { get; set; }
        public string SSLCertificateFile { get; set; }

        //TCP/IP & WIFI
        public string CountAccessRetries { get; set; }
        
        //GPRS (DATA)
        public string GPRSDialNumber { get; set; }
        public string GPRSAccessPointName { get; set; }
        public string ConnectTimeForGPRSPhone { get; set; }
        public string DialAttemptsToNetwork { get; set; }
    }
}
