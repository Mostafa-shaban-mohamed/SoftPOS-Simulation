﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace App.SoftPOS.MessageTexts
{
    public class MT_Seg01 : Entity<string>
    {
        //FK
        public string Category_ID { get; set; }
        [Required]
        public string Segment_ID { get; set; }
        public string MessageCode { get; set; }
        public string DisplayCode { get; set; }
        public string MessageTextArabic { get; set; }
        public string MessageTextEnglish { get; set; }

    }
}
