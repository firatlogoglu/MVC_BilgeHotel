using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Room:CoreEntity
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public RoomStatus RoomStatus { get; set; }

        public virtual List<BookingRoom> BookingRooms { get; set; }
    }
}
