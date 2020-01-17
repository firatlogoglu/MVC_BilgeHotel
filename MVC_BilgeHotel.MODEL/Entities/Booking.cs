using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
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
        public  DateTime InDate  { get; set; }
        public DateTime OutDate { get; set; }

        public int CostomerCount { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerID { get; set; }

        public virtual List<BookingRoom> BookingRooms { get; set; }

        //TODO: PROP Cost Maliyet
        //TODO: ID
        //TODO: PAKETLER EKLENECEK
    }
}
