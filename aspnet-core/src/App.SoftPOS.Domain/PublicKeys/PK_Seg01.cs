﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace App.SoftPOS.PublicKeys
{
    public class PK_Seg01 : Entity<string>
    {
        //FK
        public string Category_ID { get; set; }
        [Required]
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
