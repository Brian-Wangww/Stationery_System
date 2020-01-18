using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class Item
    {
        [Column("ItemId")]
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQuantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public int UnitsInStock { get; set; }
        public virtual Category Category { get; set; }
    }
}