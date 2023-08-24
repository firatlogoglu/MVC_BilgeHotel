using MVC_BilgeHotel.CORE.Entity;
using System.Data.Entity.ModelConfiguration;

namespace MVC_BilgeHotel.CORE.Map
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("ID");

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
}