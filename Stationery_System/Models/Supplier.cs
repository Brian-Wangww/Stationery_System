using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class Supplier
    {
        [Column("SupplierId")]
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public string Address { get; set; }
        public string GSTRegistration { get; set; }
    }
}