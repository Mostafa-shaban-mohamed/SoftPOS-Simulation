﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace App.SoftPOS.AIDDatas
{
    public class AD_Seg01 : Entity<string>
    {
        //FK
        public string Category_ID { get; set; }
        [Required]
        public string Segment_ID { get; set; }
        public string AID { get; set; }
        public string AIDLabel { get; set; }
        public string TerminalAIDVersionNumbers { get; set; }
        public string ExactOnlySelection { get; set; }
        public string SkipEMVProcessing { get; set; }
        public string DefaultTDOL { get; set; }
        public string DefaultDDOL { get; set; }
        public string EMVAdditionalTags { get; set; }
        public string DenialActionCode { get; set; }
        public string OnlineActionCode { get; set; }
        public string DefaultActionCode { get; set; }
        public string ThresholdValueForBaisedRandomSelection { get; set; }
        public string TargetPercentage { get; set; }
        public string MaxTargetPercentageForBasiedRandomSelection { get; set; }

    }
}
