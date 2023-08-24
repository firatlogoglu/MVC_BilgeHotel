using MVC_BilgeHotel.CORE.Map;
using MVC_BilgeHotel.MODEL.Entities;

namespace MVC_BilgeHotel.MODEL.Map
{
    public class CustomerMap : CoreMap<Customer>
    {
        public CustomerMap()
        {
            Property(x => x.TCNO).HasColumnName("TCNO");
            Property(x => x.FirstName).HasMaxLength(50).HasColumnName("FName");
            Property(x => x.SurName).HasMaxLength(50).HasColumnName("SName");
            Property(x => x.Password).HasMaxLength(20).HasColumnName("Pswrd");
            Property(x => x.Gender).HasColumnName("Gender");
            Property(x => x.BloodType).HasColumnName("BloodType");
            Property(x => x.MaritalState).HasColumnName("Marital");

            Property(x => x.PhoneNumber).HasColumnName("PhoneNo");
            Property(x => x.EmailAddress).HasMaxLength(50).HasColumnName("EMailAdrs");
            Property(x => x.Address).HasMaxLength(150);
            Property(x => x.BirthPlace).HasColumnName("BPlace");
            Property(x => x.BirthDate).HasColumnName("BDate");

            Property(x => x.User).HasColumnName("Usr");
        }
    }
}