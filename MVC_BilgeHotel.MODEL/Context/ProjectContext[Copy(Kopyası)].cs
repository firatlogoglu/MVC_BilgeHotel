using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.MODEL.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {

            //TODO: SQL Connection bağlatsını vermeyi unutmayın! Kendi SQL Server name'nizi SERVERNAME kısma yazın, database ismini varsayılan olarak MVCBilgeHotelDB tanımlanmıştır. SQL'nizdeki sizin USERNAME ve PASSWORD giriniz.
            Database.Connection.ConnectionString = "server=SERVERNAME;database=MVCBilgeHotelDB;uid=USERNAME;pwd=PASSWORD";

            //enable-migrations

            //update-database -Verbose
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new BookingRoomMap());
            modelBuilder.Configurations.Add(new CustomerBookingMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<CustomerBooking> CustomerBookings { get; set; }
    }
}
