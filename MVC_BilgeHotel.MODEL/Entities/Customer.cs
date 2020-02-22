using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Customer : PersonEntity
    {
        public Customer()
        {
            this.CustomerBookings = new List<CustomerBooking>();
        }

        [Display(Name = "Üye")]
        public bool User { get; set; }
        ////public /*virtual */CustomerBooking CustomerBooking { get; set; }
        //public virtual CustomerBooking CustomerBooking { get; set; }
        public virtual List<CustomerBooking> CustomerBookings { get; set; }
    }
}
