using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class AdjustmentVoucher
    {
        [Column("VoucherId")]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}