using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stationery_System.Enum;

namespace Stationery_System.Models
{
    public class DepUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DepRole DepRole { get; set; }
        public virtual DepEmployee DepEmployee { get; set; }
    }
}