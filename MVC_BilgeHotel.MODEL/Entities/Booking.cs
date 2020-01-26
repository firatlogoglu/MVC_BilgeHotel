using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Booking:CoreEntity
    {
        public Booking ()
        {
            BookingRooms = new List<BookingRoom>();
        }

        [Display(Name = "Giriş Tarihi:")]
        public  DateTime InDate  { get; set; }

        [Display(Name = "Çıkış Tarihi:")]
        public DateTime OutDate { get; set; }

        public int CostomerCount { get; set; }

        public virtual Customer Customer { get; set; }
        public string CustomerID { get; set; }

        public virtual List<BookingRoom> BookingRooms { get; set; }

    }
}
