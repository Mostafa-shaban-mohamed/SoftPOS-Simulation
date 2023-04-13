using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.RevokeCertificates
{
    public class RC_Seg01Dto
    {
        //FK
        public string Category_ID { get; set; }
        
        public string Segment_ID { get; set; }
        public string RID { get; set; }
        public string IDX { get; set; }
        public string CertSerialNumber { get; set; }

    }
}
