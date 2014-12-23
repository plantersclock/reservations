using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationApp.Models
{
    public class Inventory
    {
        public int id { get; set; }
        public string type {get; set; }
        public string status { get; set; }
        public bool reserved { get; set; }
        public string reservedby { get; set; }
    }
}