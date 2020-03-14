using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class CustomerBookingService : BaseService<CustomerBooking>
    {
        public bool CheckBookingCustomer(string _TCNO, Guid _BID)
        {
            return Any(z => z.Customer.TCNO == _TCNO && z.BookingID == _BID);
        }
    }
}
