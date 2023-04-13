﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS.Categories
{
    public class CategoryDto
    {
        //FK
        public string Terminal_ID { get; set; }
        public string Category_ID { get; set; }
        public string Segment_ID { get; set; }
    }
}