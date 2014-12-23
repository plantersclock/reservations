using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationApp.Models
{
    public class Reservations
    {
            public int id { get; set; }
            public string customer_name { get; set; }
            public int dv_count { get; set; }
            public int fb_count { get; set; }
            public int r_count { get; set; }
        
    }
}