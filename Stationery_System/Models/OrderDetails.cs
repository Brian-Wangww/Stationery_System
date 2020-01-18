using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int SupplierItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public virtual SupplierItem SupplierItem { get; set; }
    }
}