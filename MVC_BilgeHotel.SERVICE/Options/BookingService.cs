using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class BookingService : BaseService<Booking>
    {
        private static ProjectContext _database;
        private static ProjectContext db
        {
            get
            {
                if (_database == null)
                {
                    _database = new ProjectContext();
                }
                return _database;
            }
        }

        public List<Room> EmptyRooms()
        {
            List<Room> rooms = new List<Room>();
            DateTime dateTime = DateTime.Now;
            var sonuc = db.Bookings.Where(x => x.InDate == dateTime).Join(
            db.Rooms,
            b => b.RoomID,
            r => r.ID,
            (book, room) => new { room.ID, room.RoomNumber, room.RoomTypes });

            foreach (var item in sonuc)
            {
                Room room = new Room();
                room.ID = item.ID;
                room.RoomNumber = item.RoomNumber;
                room.RoomTypes = item.RoomTypes;
                rooms.Add(room);
            };

            return (rooms);
        }
    }
}
