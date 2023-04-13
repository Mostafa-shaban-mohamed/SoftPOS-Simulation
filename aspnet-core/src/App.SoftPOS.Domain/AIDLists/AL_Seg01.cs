﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace App.SoftPOS.AIDLists
{
    public class AL_Seg01 : Entity<string>
    {
        //FK
        public string Category_ID { get; set; }
        [Required]
        public string Segment_ID { get; set; }
        public string AID01 { get; set; }
        public string AID02 { get; set; }
        public string AID03 { get; set; }
        public string AID04 { get; set; }
        public string AID05 { get; set; }
        public string AID06 { get; set; }
        public string AID07 { get; set; }
        public string AID08 { get; set; }
        public string AID09 { get; set; }
        public string AID010 { get; set; }

    }
}
