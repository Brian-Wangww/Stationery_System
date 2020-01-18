using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class StoreEmployee
    {
        [Column("StoreEmployeeId")]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
    }
}