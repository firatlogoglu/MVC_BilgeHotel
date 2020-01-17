using MVC_BilgeHotel.CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Entity
{
    public class PersonEntity : CoreEntity
    {
        public new string ID { get; set; }

        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }

        public Sexies Sex { get; set; }
        public enum Sexies
        {
            Male = 0,
            Member = 1,
        }
    }
}
