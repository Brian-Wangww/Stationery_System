using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class VoucherDetails
    {
        [Column("VoucherId")]
        public int AdjustmentVoucherId { get; set; }
        public int ItemId { get; set; }
        public int QuantityAdjusted { get; set; }
        public string Reason { get; set; }
        public virtual AdjustmentVoucher AdjustmentVoucher { get; set; }
        public virtual Item Item { get; set; }
    }
}