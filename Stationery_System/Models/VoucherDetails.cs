using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class VoucherDetails
    {
        [Key]
        [Column("VoucherId",Order =0)]
        public int AdjustmentVoucherId { get; set; }
        [Key,Column(Order =1)]
        public int ItemId { get; set; }
        public int QuantityAdjusted { get; set; }
        public string Reason { get; set; }
        public virtual AdjustmentVoucher AdjustmentVoucher { get; set; }
        public virtual Item Item { get; set; }
    }
}