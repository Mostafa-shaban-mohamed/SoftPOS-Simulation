﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.CardSchemas
{
    public class CS_Seg03Dto
    {
        //FK
        public string Category_ID { get; set; }

        public string Segment_ID { get; set; }
        public string CardSchemeID { get; set; }
        public string CardRanges { get; set; }
        public string CardPrefixSequenceIndicator { get; set; }
    }
}
