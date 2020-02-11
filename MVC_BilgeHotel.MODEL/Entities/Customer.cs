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
            CustomerBookings = new List<CustomerBooking>();

        }
        public virtual List<CustomerBooking> CustomerBookings { get; set; }

        public Guid CustomerBookingID { get; set; }

        [Display(Name = "Üye")]
        public bool User { get; set; }

    }
}
