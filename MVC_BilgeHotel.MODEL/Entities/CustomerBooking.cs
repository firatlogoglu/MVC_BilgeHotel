using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class CustomerBooking : CoreEntity
    {
        public Guid BookingID { get; set; }
        public Guid CustomerID { get; set; }
    }
}
