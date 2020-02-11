using MVC_BilgeHotel.CORE.Map;
using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Map
{
    public class RoomMap : CoreMap<Room>
    {
        public RoomMap()
        {
            Property(x => x.ImagePath).HasColumnName("ImgPath");
            Property(x => x.RoomNumber).HasColumnName("RNo");
            Property(x => x.RoomStatus).HasColumnName("RStatus");
            Property(x => x.RoomTypes).HasColumnName("RTypes");
            Property(x => x.Capacity).HasColumnName("Capacity");
        }
    }
}
