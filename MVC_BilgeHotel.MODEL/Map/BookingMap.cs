using MVC_BilgeHotel.CORE.Map;
using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Map
{
    public class BookingMap : CoreMap<Booking>
    {
        public BookingMap()
        {
            Property(x => x.InDate).HasColumnName("InDate");
            Property(x => x.OutDate).HasColumnName("OutDate");
            Property(x => x.Package).HasColumnName("Pckg");
            Property(x => x.Description).HasColumnName("Description");

            Property(x => x.CostomerCount).HasColumnName("CstmerCount");
            Property(x => x.Paid).HasColumnName("Paid");
            Property(x => x.TotalDays).HasColumnName("TDays").IsOptional();
            Property(x => x.TotalPrice).HasColumnName("TPrice").IsOptional();
            Property(x => x.UnitPrice).HasColumnName("UntPrice");
            Property(x => x.ExtraPrice).HasColumnName("ExPrice").IsOptional();
        }
    }
}
