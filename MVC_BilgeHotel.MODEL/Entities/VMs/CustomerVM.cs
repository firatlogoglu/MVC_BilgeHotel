using MVC_BilgeHotel.CORE.Enums.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BilgeHotel.MODEL.Entities.VMs
{
    public class CustomerVM
    {
        public ushort ID { get; set; }
        public string TCNO { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public BloodType BloodType { get; set; }
        public MaritalState MaritalState { get; set; }
    }
}