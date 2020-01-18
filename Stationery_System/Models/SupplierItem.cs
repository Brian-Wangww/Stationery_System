using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class SupplierItem
    {
        [Column("SupplierItemId")]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Item Item { get; set; }
    }
}