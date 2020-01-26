using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Room : CoreEntity
    {
        [Display(Name = "Oda No:")]
        public string RoomNumber { get; set; }

        [Display(Name = "Kapasite:")]
        public int Capacity { get; set; }

        [Display(Name = "Oda Durumu:")]
        public RoomStatus RoomStatus { get; set; }

        public virtual List<BookingRoom> BookingRooms { get; set; }
    }
}
