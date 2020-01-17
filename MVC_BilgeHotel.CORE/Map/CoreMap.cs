using MVC_BilgeHotel.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Map
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.GeneralStatus).HasColumnName("GStatus");

            Property(x => x.CreatedDate).HasColumnName("CrtdDate");           
            Property(x => x.CreatedIP).HasMaxLength(50).HasColumnName("CrtdIP");
            Property(x => x.CreatedComputerUsername).HasMaxLength(50).HasColumnName("CrtdCUsrName");
            Property(x => x.CreatedComputerName).HasMaxLength(50).HasColumnName("CrtdCmpName");

            Property(x => x.ModifiedDate).HasColumnName("MdfDate");
            Property(x => x.ModifiedIP).HasMaxLength(50).HasColumnName("MdfIP");
            Property(x => x.ModifiedComputerName).HasMaxLength(50).HasColumnName("MdfCmpName");
            Property(x => x.ModifiedComputerUsername).HasMaxLength(50).HasColumnName("MdfCUsrName");
        }
    }
    //TODO: Hata!!

    //public class PersonMap<T>: EntityTypeConfiguration<T> where T : PersonEntity
    //{
    //    public PersonMap()
    //    {
    //        Property(x => x.FirstName).HasMaxLength(50).HasColumnName("Isim");
    //        Property(x => x.SurName).HasMaxLength(50);
    //    }
    //}
}
