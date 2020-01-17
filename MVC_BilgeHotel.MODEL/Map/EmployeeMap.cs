using MVC_BilgeHotel.CORE.Map;
using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Map
{
    public class EmployeeMap : CoreMap<Employee>
    {
        public EmployeeMap()
        {
            Property(x => x.FirstName).HasMaxLength(50).HasColumnName("FName");
            Property(x => x.SurName).HasMaxLength(50).HasColumnName("SName");
            Property(x => x.Password).HasMaxLength(20).HasColumnName("Pswrd");

            Property(x => x.EmailAddress).HasMaxLength(50).HasColumnName("EMailAdrs");

            Property(x => x.BirthDate).HasColumnName("BDate");
            Property(x => x.BirthPlace).HasColumnName("BPlace");
            //TODO: MAPPING YAPILACAK
            //TODO: Address eklenene
        }
    }
}
