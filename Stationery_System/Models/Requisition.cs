using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class Requisition
    {
        [Column("RequisitionId")]
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }
        public virtual DepEmployee DepEmployee { get; set; }

    }
}