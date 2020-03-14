using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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