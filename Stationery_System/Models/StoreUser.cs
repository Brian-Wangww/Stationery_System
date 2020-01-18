using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Stationery_System.Enum;

namespace Stationery_System.Models
{
    public class StoreUser
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public StoreRole StoreRole { get; set; }
        public virtual StoreEmployee StoreEmployee { get; set; }
    }
}