using MVC_BilgeHotel.CORE.Entity;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.MODEL.Map;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MVC_BilgeHotel.MODEL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            //TODO: SQL Connection bağlatsı varsayılan olarak tanımlanmıştır. Varsayılanın dışında bir bağlantı için, kendi SQL Server name'nizi ". (nokta)" yerine yazın, database ismini varsayılan olarak MVCBilgeHotelDB tanımlanmıştır. sa'nın yerine kullanıcı adınızı ve 123 yerine şifrenizi girebilirisiniz.
            Database.Connection.ConnectionString = "server=.;database=MVCBilgeHotelDB;uid=sa;pwd=123";

            //enable-migrations
            //update-database -Verbose
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new CustomerBookingMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBooking> CustomerBookings { get; set; }

        public override int SaveChanges()
        {
            var modifedEntry = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);

            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            int user = 1;

            string ip = "";
            if (HttpContext.Current == null)
            {
                ip = "192.168.1.1";
            }
            else
            {
                ip = HttpContext.Current.Request.UserHostAddress.ToString();
            }

            foreach (var item in modifedEntry)
            {
                CoreEntity entity = item.Entity as CoreEntity;

                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CreatedComputerUsername = identity;
                        entity.CreatedComputerName = computerName;
                        entity.CreatedDate = dateTime;
                        entity.CreatedUserID = user;
                        entity.CreatedIP = ip;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        entity.ModifiedComputerUsername = identity;
                        entity.ModifiedComputerName = computerName;
                        entity.ModifiedDate = dateTime;
                        entity.ModifiedIP = ip;
                        entity.ModifiedUserID = user;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}