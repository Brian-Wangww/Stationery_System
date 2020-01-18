using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class RequisitionDetail
    {
        public int RequisitionId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public virtual Requisition Requisition { get; set; }
        public virtual Item Item { get; set; }

    }
}