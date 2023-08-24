using MVC_BilgeHotel.CORE.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_BilgeHotel.MODEL.Entities.VMs
{
    public class CustomerBookingsVM : PersonEntity
    {
        public Guid CustomerBookingID { get; set; }
        public Guid BookingID { get; set; }

        [Display(Name = "Üye")]
        public bool User { get; set; }

        [Display(Name = "Kişi Sayası")]
        public int CostomerCount { get; set; }

        [Display(Name = "Eklenen Kişi Sayası")]
        public int AddCostomerCount { get; set; }
    }
}