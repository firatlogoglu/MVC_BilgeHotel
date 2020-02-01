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

            //TODO: ID ISOPTION KALDIRILACAK

            Property(x => x.ID).IsOptional();

            Property(x => x.FirstName).HasMaxLength(50).HasColumnName("FName");
            Property(x => x.SurName).HasMaxLength(50).HasColumnName("SName");
            Property(x => x.Password).HasMaxLength(100).HasColumnName("Pswrd");

            Property(x => x.EmailAddress).HasMaxLength(50).HasColumnName("EMailAdrs");
            Property(x => x.Address).HasMaxLength(150);
            Property(x => x.BirthDate).HasColumnName("BDate");
            Property(x => x.BirthPlace).HasColumnName("BPlace");

        }
    }
}
