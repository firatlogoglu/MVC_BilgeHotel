using MVC_BilgeHotel.CORE.Map;
using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Map
{
    public class CustomerBookingMap : CoreMap<CustomerBooking>
    {
        public CustomerBookingMap()
        {
           
            Property(x => x.ID).HasColumnName("ID");
            //HasKey(x => new { x.CustomerID, x.BookingID });

            Property(x => x.CustomerID).HasColumnName("CID").IsOptional();
            Property(x => x.BookingID).HasColumnName("BID").IsOptional();
            

        }
    }
}
