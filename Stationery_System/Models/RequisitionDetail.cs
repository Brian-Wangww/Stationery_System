using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class RequisitionDetail
    {
        [Key,Column(Order=0)]
        public int RequisitionId { get; set; }
        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public virtual Requisition Requisition { get; set; }
        public virtual Item Item { get; set; }

    }
}