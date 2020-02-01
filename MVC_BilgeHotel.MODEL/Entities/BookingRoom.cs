using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class BookingRoom: CoreEntity
    {
        //TODO: BookingRoom protetyler tanımlanacak
        public Guid RoomID { get; set; }

        public Guid BookingID { get; set; }
    }
}
