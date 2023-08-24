using MVC_BilgeHotel.CORE.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public virtual List<CustomerBooking> CustomerBookings { get; set; }
    }
}