using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.MODEL.Entities.VMs;
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
        //TODO: SQL BAĞLANTI SORUN
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

        public List<Booking> FindBookings(Guid cid)
        {
            var v1 = db.CustomerBookings.Where(x => x.CustomerID == cid).Join(
                db.Bookings,
                cb => cb.BookingID,
                b => b.ID,
                (cubok, book) => new { cubok, book })

                .Join(db.Rooms,
                book => book.book.RoomID,
                room => room.ID,
                (book, room) => new { book.book, room });

            List<Booking> bookings = new List<Booking>();

            foreach (var item in v1)
            {
                Booking b = new Booking();

                b.ID = item.book.ID;
                b.InDate = item.book.InDate;
                b.OutDate = item.book.OutDate;
                b.RoomID = item.book.RoomID;
                b.Room = item.room;
                b.Package = item.book.Package;
                b.UnitPrice = item.book.UnitPrice;
                b.ExtraPrice = item.book.ExtraPrice;
                b.TotalPrice = item.book.TotalPrice;
                b.Paid = item.book.Paid;
                b.TotalDays = item.book.TotalDays;
                b.CostomerCount = item.book.CostomerCount;
                b.AddCostomerCount = item.book.AddCostomerCount;
                b.Description = item.book.Description;
                bookings.Add(b);
            }
            return (bookings);
        }

        public List<Room> EmptyRooms(DateTime indate, DateTime outdate, int count)
        {
            List<Room> rooms = new List<Room>();

            List<Room> finalsrooms = new List<Room>();
            var sonuc = db.Rooms.Where(r => !db.Bookings.Any(b => b.RoomID == r.ID && b.GeneralStatus != CORE.Enums.GeneralStatus.Deleted && (((b.InDate >= indate && b.InDate <= outdate)) || (b.OutDate >= indate && b.OutDate <= outdate) || (b.InDate <= indate && b.OutDate >= outdate))));

            foreach (var item in sonuc)
            {
                Room allroom = new Room();

                allroom.ID = item.ID;
                allroom.ImagePath = item.ImagePath;
                allroom.RoomNumber = item.RoomNumber;
                allroom.RoomTypes = item.RoomTypes;
                allroom.GeneralStatus = item.GeneralStatus;
                allroom.RoomStatus = item.RoomStatus;
                allroom.Capacity = item.Capacity;
                rooms.Add(allroom);
            };

            foreach (var item2 in rooms)
            {
                if (item2.Capacity >= count)
                {
                    Room room = new Room();

                    room.ID = item2.ID;
                    room.ImagePath = item2.ImagePath;
                    room.RoomNumber = item2.RoomNumber;
                    room.RoomTypes = item2.RoomTypes;
                    room.GeneralStatus = item2.GeneralStatus;
                    room.RoomStatus = item2.RoomStatus;
                    room.Capacity = item2.Capacity;
                    finalsrooms.Add(room);
                }
            }
            return (finalsrooms);
        }

        public List<CustomerBookingsVM> FindcustomerBookings(Guid bid)
        {
            var v1 = db.CustomerBookings.Where(x => x.BookingID == bid).Join(
                db.Bookings,
                cb => cb.BookingID,
                b => b.ID,
                (cubok, book) => new { cubok, book })

            .Join(db.Customers,
            book => book.cubok.CustomerID,
            cus => cus.ID,
            (cusbok, cus) => new { cusbok, cus });

            List<CustomerBookingsVM> CustomerBookings = new List<CustomerBookingsVM>();

            foreach (var item in v1)
            {
                CustomerBookingsVM cbv = new CustomerBookingsVM();
                cbv.CustomerBookingID = item.cusbok.cubok.ID;
                cbv.ID = item.cus.ID;
                cbv.TCNO = item.cus.TCNO;
                cbv.FirstName = item.cus.FirstName;
                cbv.SurName = item.cus.SurName;
                cbv.Gender = item.cus.Gender;

                cbv.BirthDate = item.cus.BirthDate;
                cbv.BirthPlace = item.cus.BirthPlace;

                cbv.Address = item.cus.Address;
                cbv.EmailAddress = item.cus.EmailAddress;

                cbv.BookingID = item.cusbok.book.ID;
                cbv.CostomerCount = item.cusbok.book.CostomerCount;
                cbv.AddCostomerCount = item.cusbok.cubok.Booking.AddCostomerCount;
                CustomerBookings.Add(cbv);
            }
            return (CustomerBookings);
        }
    }
}