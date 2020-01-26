using MVC_BilgeHotel.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.Context
{
    public class SampleData : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            //TODO: SEED BASMAMA SORUNU

            //
            //            SampleData data = new SampleData();
            //      data.InitializeDatabase(context);

            #region Odalar
            IList<Room> rooms = new List<Room>();

            rooms.Add(new Room() { ID = Guid.NewGuid(), RoomNumber = "001", RoomStatus = Enums.RoomStatus.Full, Capacity = 1 });
            rooms.Add(new Room() { ID = Guid.NewGuid(), RoomNumber = "002", RoomStatus = Enums.RoomStatus.Full, Capacity = 1 });

            context.Rooms.AddRange(rooms);
            #endregion

            #region Çalışanlar

            IList<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                ID = Guid.NewGuid(),
                BirthDate = new DateTime(1994, 4, 1),
                BirthPlace = "Biga",
                FirstName = "Fırat",
                SurName = "Loğoğlu",
                Gender = CORE.Enums.Gender.Male,
                Password = "1234",
                TCNO = "11111111",
                Role = Enums.Roles.Receptionist,
                EmailAddress = "firat@mmm.com",
                GeneralStatus = CORE.Enums.GeneralStatus.Active
            });

            context.Employees.AddRange(employees);

            #endregion

            #region Müşteriler
            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                ID = Guid.NewGuid(),
                TCNO = "22222222222",
                FirstName = "Fırat",
                SurName = "Loğoğlu",
                EmailAddress = "firatlogoglu@mmm.com",
                Gender = CORE.Enums.Gender.Male,                
                User = false,              
                BirthDate = new DateTime(1994, 1, 4),
                BirthPlace = "Biga",
                Password = "1234",
                PhoneNumber = "05555555555"
                
            });

            context.Customers.AddRange(customers);
            #endregion


            base.Seed(context);
        }
    }
}
