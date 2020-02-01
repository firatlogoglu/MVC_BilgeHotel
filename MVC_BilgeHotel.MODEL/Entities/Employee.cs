using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Enums;

namespace MVC_BilgeHotel.MODEL.Entities
{
    public class Employee : PersonEntity
    {
        [Display(Name = "Resim")]
        public string ImagePath { get; set; }

        [Display(Name = "Görev")]
        public Roles? Role { get; set; }

        [Display(Name = "Saat Başı Ücret")]
        public decimal HourlyPay { get; set; }

        [Display(Name = "Çalışma Saatleri")]
        public int Hours { get; set; }

        [Display(Name = "Çalıştığı Gün")]
        public int Days { get ; set; }

        [Display(Name = "Ek Saat")]
        public int EkstraHours{ get; set; }

        [Display(Name = "Toplam Ücret")]
        public decimal TotalPay { get; set; }

        [Display(Name = "Vardiya")]
        public Shifts Shift { get; set; }

        [Display(Name = "Ödendi")]
        public bool Paid { get; set; }
    }
}
