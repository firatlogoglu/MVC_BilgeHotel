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
    public class Booking : CoreEntity
    {
        public Booking()
        {
            CustomerBookings = new List<CustomerBooking>();

            Entry = false;
        }

        [Display(Name = "Giriş Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InDate { get; set; }

        [Display(Name = "Çıkış Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OutDate { get; set; }

        [Display(Name = "Kişi Sayası")]
        public int CostomerCount { get; set; }

        [Display(Name = "Birim Fiyat")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Ekstra Ücret")]
        public decimal ExtraPrice { get; set; }

        [Display(Name = "Toplam Fiyat")]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Toplam Gün")]
        public int TotalDays { get; set; }

        [Display(Name = "Paket")]
        public BookingPackages Package { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Ödendi")]
        public bool Paid { get; set; }

        [Display(Name = "GirişYapıldı")]
        public bool Entry { get; set; }

        public Guid RoomID { get; set; }

        public virtual List<CustomerBooking> CustomerBookings { get; set; }
        public virtual Room Room { get; set; }
    }
}
