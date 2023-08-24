using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Room : CoreEntity
    {
        public Room()
        {
            this.Bookings = new HashSet<Booking>();
        }

        [Display(Name = "Oda No")]
        [Required(ErrorMessage = "Oda Numarasının Girilmesi Zorunludur!")]
        public string RoomNumber { get; set; }

        [Display(Name = "Kapasite")]
        [Required(ErrorMessage = "Oda Kapasitesinin Girilmesi Zorunludur!")]
        [Range(1, 8, ErrorMessage = "{0}")]
        public int Capacity { get; set; }

        [Display(Name = "Oda Durumu")]
        [Required(ErrorMessage = "Oda Durumunun Girilmesi Zorunludur!")]

        public RoomStatus RoomStatus { get; set; }

        [Display(Name = "Resim")]
        public string ImagePath { get; set; }

        [Display(Name = "Tür")]
        public RoomTypes RoomTypes { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}