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

        public string ImagePath { get; set; }

        [Display(Name = "Görev:")]
        public Roles? Role { get; set; }

    }
}
