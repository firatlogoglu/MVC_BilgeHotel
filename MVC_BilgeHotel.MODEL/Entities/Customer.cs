using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Customer : PersonEntity
    {
        public new int ID { get; set; }

        //TODO: MAPPİNG YAPILMADI
        public virtual List<Booking> Bookings { get; set; }
    }
}
