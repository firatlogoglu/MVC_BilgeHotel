using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.MODEL.Enums;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class RoomService : BaseService<Room>
    {
        //private static ProjectContext _database;
        //private static ProjectContext db
        //{
        //    get
        //    {
        //        if (_database == null)
        //        {
        //            _database = new ProjectContext();
        //        }
        //        return _database;
        //    }
        //}

        ProjectContext db = new ProjectContext();

        public List<Room> GetRoomEmtpy(Room room)
        {
            return db.Set<Room>().Where(x => x.RoomStatus == MVC_BilgeHotel.MODEL.Enums.RoomStatus.Empty).ToList();
        }

        public List<Room> GetRoomFull()
        {
            return db.Set<Room>().Where(x => x.RoomStatus == MVC_BilgeHotel.MODEL.Enums.RoomStatus.Full).ToList();
        }
    }
}
