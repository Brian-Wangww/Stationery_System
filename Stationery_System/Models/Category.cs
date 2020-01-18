using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class Category
    {
        [Column("CategoryId")]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}