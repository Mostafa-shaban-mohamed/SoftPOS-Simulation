using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace App.SoftPOS.ISOMsgs
{
    public class ISOMsg :  Entity<Guid>
    {
        [Required]
        public string BufferMsg { get; set; }
    }
}