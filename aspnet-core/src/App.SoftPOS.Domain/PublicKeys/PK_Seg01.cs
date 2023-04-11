using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.PublicKeys
{
    public class PK_Seg01
    {
        public string Segment_ID { get; set; }
        public string RID { get; set; }
        public string KeyIndex { get; set; }
        public string HashID { get; set; }
        public string DigitalSignatureID { get; set; }
        public string PublicKey { get; set; }
        public string Exponent { get; set; }
        public string CheckSum { get; set; }
        public string CAPublicKeyLength { get; set; }
        public string CAPublicKeyExpiryDate { get; set; }
    }
}
