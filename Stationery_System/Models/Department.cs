using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stationery_System.Models
{
    public class Department
    {
        [Column("DepartmentId")]
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public string CollectionPoint { get; set; }
        [ForeignKey("DepEmployees")]
        public int RepresentativeId { get; set; }
        [ForeignKey("DepEmployees")]
        public int ContactPersonId { get; set; }
        public virtual ICollection<DepEmployee> DepEmployees { get; set; }
    }
}