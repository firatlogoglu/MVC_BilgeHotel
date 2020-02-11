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
            //TODO: Seed Basmak için aşağıda yorum satırı içerinde bulunan kodların, Model katmanı içerisinde bulunan Migrations içerisinede bulunan, Configuration classı içerisine Seed metot içerisine verilmesi gerekmektedir. Migrations sillerseniz tekrardan burdan yapıştırabilirisiniz.

            //
            //            SampleData data = new SampleData();
            //      data.InitializeDatabase(context);


            Guid c1 = Guid.NewGuid();
            Guid cb1 = Guid.NewGuid();

            Guid boook1 = Guid.NewGuid();
            Guid boook2 = Guid.NewGuid();
            Guid boook3 = Guid.NewGuid();
            Guid boook4 = Guid.NewGuid();
            Guid boook5 = Guid.NewGuid();
            Guid boook6 = Guid.NewGuid();

            Guid br1 = Guid.NewGuid();
            Guid br2 = Guid.NewGuid();

            #region Odalar

            #region OdaKisiTurResimYollari
            string single = "/Uploads/Img/Rooms/SingleRoom.jpg";
            string twin = "/Uploads/Img/Rooms/TwinRoom.jpg";
            string sdouble = "/Uploads/Img/Rooms/DoubleRoom.jpg";
            string triple = "/Uploads/Img/Rooms/TripleRoom.jpg";
            string triple2 = "/Uploads/Img/Rooms/triple2.jpg";
            string quad = "/Uploads/Img/Rooms/QuadRoom.jpg";
            string king = "/Uploads/Img/Rooms/KingRoom.jpg";
            #endregion

            #region IDler 
            #region 1.KatOdaIdleri
            Guid room100 = Guid.NewGuid();
            Guid room101 = Guid.NewGuid();
            Guid room102 = Guid.NewGuid();
            Guid room103 = Guid.NewGuid();
            Guid room104 = Guid.NewGuid();
            Guid room105 = Guid.NewGuid();
            Guid room106 = Guid.NewGuid();
            Guid room107 = Guid.NewGuid();
            Guid room108 = Guid.NewGuid();
            Guid room109 = Guid.NewGuid();

            Guid room110 = Guid.NewGuid();
            Guid room111 = Guid.NewGuid();
            Guid room112 = Guid.NewGuid();
            Guid room113 = Guid.NewGuid();
            Guid room114 = Guid.NewGuid();
            Guid room115 = Guid.NewGuid();
            Guid room116 = Guid.NewGuid();
            Guid room117 = Guid.NewGuid();
            Guid room118 = Guid.NewGuid();
            Guid room119 = Guid.NewGuid();
            #endregion

            #region 2.KatOdaIdleri
            Guid room200 = Guid.NewGuid();
            Guid room201 = Guid.NewGuid();
            Guid room202 = Guid.NewGuid();
            Guid room203 = Guid.NewGuid();
            Guid room204 = Guid.NewGuid();
            Guid room205 = Guid.NewGuid();
            Guid room206 = Guid.NewGuid();
            Guid room207 = Guid.NewGuid();
            Guid room208 = Guid.NewGuid();
            Guid room209 = Guid.NewGuid();

            Guid room210 = Guid.NewGuid();
            Guid room211 = Guid.NewGuid();
            Guid room212 = Guid.NewGuid();
            Guid room213 = Guid.NewGuid();
            Guid room214 = Guid.NewGuid();
            Guid room215 = Guid.NewGuid();
            Guid room216 = Guid.NewGuid();
            Guid room217 = Guid.NewGuid();
            Guid room218 = Guid.NewGuid();
            Guid room219 = Guid.NewGuid();
            #endregion

            #region 3.KatOdaIdleri
            Guid room300 = Guid.NewGuid();
            Guid room301 = Guid.NewGuid();
            Guid room302 = Guid.NewGuid();
            Guid room303 = Guid.NewGuid();
            Guid room304 = Guid.NewGuid();
            Guid room305 = Guid.NewGuid();
            Guid room306 = Guid.NewGuid();
            Guid room307 = Guid.NewGuid();
            Guid room308 = Guid.NewGuid();
            Guid room309 = Guid.NewGuid();

            Guid room310 = Guid.NewGuid();
            Guid room311 = Guid.NewGuid();
            Guid room312 = Guid.NewGuid();
            Guid room313 = Guid.NewGuid();
            Guid room314 = Guid.NewGuid();
            Guid room315 = Guid.NewGuid();
            Guid room316 = Guid.NewGuid();
            Guid room317 = Guid.NewGuid();
            Guid room318 = Guid.NewGuid();
            Guid room319 = Guid.NewGuid();
            #endregion

            #region 4.KatOdaIdleri
            Guid room400 = Guid.NewGuid();
            Guid room401 = Guid.NewGuid();
            Guid room402 = Guid.NewGuid();
            Guid room403 = Guid.NewGuid();
            Guid room404 = Guid.NewGuid();
            Guid room405 = Guid.NewGuid();
            Guid room406 = Guid.NewGuid();
            Guid room407 = Guid.NewGuid();
            Guid room408 = Guid.NewGuid();
            Guid room409 = Guid.NewGuid();

            Guid room410 = Guid.NewGuid();
            Guid room411 = Guid.NewGuid();
            Guid room412 = Guid.NewGuid();
            Guid room413 = Guid.NewGuid();
            Guid room414 = Guid.NewGuid();
            Guid room415 = Guid.NewGuid();
            Guid room416 = Guid.NewGuid();
            #endregion

            #endregion

            IList<Room> rooms = new List<Room>();

            #region 1.Kat Odalar
            rooms.Add(new Room() { ID = room100, RoomNumber = "100", RoomStatus = Enums.RoomStatus.Full, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room101, RoomNumber = "101", RoomStatus = Enums.RoomStatus.Full, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room102, RoomNumber = "102", RoomStatus = Enums.RoomStatus.Full, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room103, RoomNumber = "103", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room104, RoomNumber = "104", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room105, RoomNumber = "105", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room106, RoomNumber = "106", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room107, RoomNumber = "107", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room108, RoomNumber = "108", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room109, RoomNumber = "109", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });

            rooms.Add(new Room() { ID = room110, RoomNumber = "110", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room111, RoomNumber = "111", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room112, RoomNumber = "112", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room113, RoomNumber = "113", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room114, RoomNumber = "114", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room115, RoomNumber = "115", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room116, RoomNumber = "116", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room117, RoomNumber = "117", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room118, RoomNumber = "118", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            rooms.Add(new Room() { ID = room119, RoomNumber = "119", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple });
            #endregion

            #region 2.Kat Odalar
            rooms.Add(new Room() { ID = room200, RoomNumber = "200", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room201, RoomNumber = "201", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room202, RoomNumber = "202", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room203, RoomNumber = "203", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room204, RoomNumber = "204", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room205, RoomNumber = "205", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room206, RoomNumber = "206", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room207, RoomNumber = "207", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room208, RoomNumber = "208", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });
            rooms.Add(new Room() { ID = room209, RoomNumber = "209", RoomStatus = Enums.RoomStatus.Empty, Capacity = 1, RoomTypes = Enums.RoomTypes.Single, ImagePath = single });

            rooms.Add(new Room() { ID = room210, RoomNumber = "210", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room211, RoomNumber = "211", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room212, RoomNumber = "212", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room213, RoomNumber = "213", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room214, RoomNumber = "214", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room215, RoomNumber = "215", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room216, RoomNumber = "216", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room217, RoomNumber = "217", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room218, RoomNumber = "218", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });
            rooms.Add(new Room() { ID = room219, RoomNumber = "219", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Twin, ImagePath = twin });

            #endregion

            #region 3.Kat Odalar
            rooms.Add(new Room() { ID = room300, RoomNumber = "300", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room301, RoomNumber = "301", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room302, RoomNumber = "302", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room303, RoomNumber = "303", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room304, RoomNumber = "304", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room305, RoomNumber = "305", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room306, RoomNumber = "306", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room307, RoomNumber = "307", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room308, RoomNumber = "308", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room309, RoomNumber = "309", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });

            rooms.Add(new Room() { ID = room310, RoomNumber = "310", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room311, RoomNumber = "311", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room312, RoomNumber = "312", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room313, RoomNumber = "313", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room314, RoomNumber = "314", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room315, RoomNumber = "315", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room316, RoomNumber = "316", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room317, RoomNumber = "317", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room318, RoomNumber = "318", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            rooms.Add(new Room() { ID = room319, RoomNumber = "319", RoomStatus = Enums.RoomStatus.Empty, Capacity = 3, RoomTypes = Enums.RoomTypes.Triple, ImagePath = triple2 });
            #endregion

            #region 4.Kat Odalar
            rooms.Add(new Room() { ID = room400, RoomNumber = "400", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room401, RoomNumber = "401", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room402, RoomNumber = "402", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room403, RoomNumber = "403", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room404, RoomNumber = "404", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room405, RoomNumber = "405", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room406, RoomNumber = "406", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room407, RoomNumber = "407", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room408, RoomNumber = "408", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });
            rooms.Add(new Room() { ID = room409, RoomNumber = "409", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.Double, ImagePath = sdouble });

            rooms.Add(new Room() { ID = room410, RoomNumber = "410", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room411, RoomNumber = "411", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room412, RoomNumber = "412", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room413, RoomNumber = "413", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room414, RoomNumber = "414", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room415, RoomNumber = "415", RoomStatus = Enums.RoomStatus.Empty, Capacity = 4, RoomTypes = Enums.RoomTypes.Quad, ImagePath = quad });
            rooms.Add(new Room() { ID = room416, RoomNumber = "416", RoomStatus = Enums.RoomStatus.Empty, Capacity = 2, RoomTypes = Enums.RoomTypes.King, ImagePath = king });
            #endregion

            context.Rooms.AddRange(rooms);
            #endregion

            #region Çalışanlar

            IList<Employee> employees = new List<Employee>();

            Guid emrp1 = Guid.NewGuid();
            Guid emrp2 = Guid.NewGuid();
            Guid emrp3 = Guid.NewGuid();
            Guid emrp4 = Guid.NewGuid();
            Guid emrp5 = Guid.NewGuid();
            Guid emrp6 = Guid.NewGuid();
            Guid emrp7 = Guid.NewGuid();

            Guid emma1 = Guid.NewGuid();
            #region Receptionists

            string receptionist1 = "/Uploads/Img/Employee/receptionist.jpg";
            string receptionist2 = "/Uploads/Img/Employee/receptionist2.jpg";

            employees.Add(new Employee()
            {
                ID = emrp1,
                TCNO = "111111111",
                BirthDate = new DateTime(1990, 4, 1),
                BirthPlace = "İstanbul",
                FirstName = "Mehmet",
                SurName = "Gün",
                Gender = CORE.Enums.Gender.Male,
                EmailAddress = "mehmetgun@smail.com",
                Password = "1234",
                Role = Enums.Roles.Receptionist,
                PhoneNumber = "05350000000",
                Address = "Havaalanı yolu",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Shift = Enums.Shifts.Gündüz,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = true,
                ImagePath = receptionist1
            });

            employees.Add(new Employee()
            {
                ID = emrp2,
                TCNO = "100000000",
                BirthDate = new DateTime(1991, 3, 1),
                BirthPlace = "Çanakkale",
                FirstName = "Ayşe",
                SurName = "Çalışkan",
                Gender = CORE.Enums.Gender.Female,
                EmailAddress = "aysecaliskan@smail.com",
                Password = "32145",
                Role = Enums.Roles.Receptionist,
                Address = "Atatürk Cad.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "2120000000",
                Shift = Enums.Shifts.Gündüz,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = false,
                ImagePath = receptionist2
            });

            employees.Add(new Employee()
            {
                ID = emrp3,
                TCNO = "12324233",
                BirthDate = new DateTime(1990, 5, 1),
                BirthPlace = "Adana",
                FirstName = "Fırat",
                SurName = "Şahin",
                Gender = CORE.Enums.Gender.Male,
                EmailAddress = "firatsahin@smail.com",
                Password = "456312",
                Role = Enums.Roles.Receptionist,
                Address = "Yukarı Yol Cad.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200000123",
                Shift = Enums.Shifts.Akşam,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = true,
                ImagePath = receptionist1
            });

            employees.Add(new Employee()
            {
                ID = emrp4,
                TCNO = "234242333",
                BirthDate = new DateTime(1993, 6, 4),
                BirthPlace = "Tekirdağ",
                FirstName = "Fatma",
                SurName = "Irmak",
                Gender = CORE.Enums.Gender.Female,
                EmailAddress = "fatmagirmak@smail.com",
                Password = "1324",
                Role = Enums.Roles.Receptionist,
                Address = "Kestirme Sok.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200000336",
                Shift = Enums.Shifts.Akşam,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = true,
                ImagePath = receptionist2
            });

            employees.Add(new Employee()
            {
                ID = emrp5,
                TCNO = "532564345",
                BirthDate = new DateTime(1988, 5, 4),
                BirthPlace = "Hatay",
                FirstName = "Ali",
                SurName = "Gün",
                Gender = CORE.Enums.Gender.Male,
                EmailAddress = "aligun@smail.com",
                Password = "1123",
                Role = Enums.Roles.Receptionist,
                Address = "Çıkmaz Sok.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200000550",
                Shift = Enums.Shifts.Gece,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = false,
                ImagePath = receptionist1
            });

            employees.Add(new Employee()
            {
                ID = emrp6,
                TCNO = "532564552",
                BirthDate = new DateTime(1982, 5, 4),
                BirthPlace = "Sinop",
                FirstName = "Gülistan",
                SurName = "Karakaya",
                Gender = CORE.Enums.Gender.Female,
                EmailAddress = "gulistankarakaya@smail.com",
                Password = "4231",
                Role = Enums.Roles.Receptionist,
                Address = "Çıkmaz Sok.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200000550",
                Shift = Enums.Shifts.Gece,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = false,
                ImagePath = receptionist2
            });

            employees.Add(new Employee()
            {
                ID = emrp7,
                TCNO = "80153652",
                BirthDate = new DateTime(1991, 10, 10),
                BirthPlace = "Ankara",
                FirstName = "Mustafa",
                SurName = "Bilge",
                Gender = CORE.Enums.Gender.Male,
                EmailAddress = "mustafabilge@smail.com",
                Password = "2134",
                Role = Enums.Roles.Receptionist,
                Address = "Çalı Sok.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200011150",
                Shift = Enums.Shifts.Gündüz,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                EkstraHours = 2,
                TotalPay = 26000.00m,
                Paid = true,
                ImagePath = receptionist1
            });
            #endregion

            employees.Add(new Employee()
            {
                ID = emma1,
                TCNO = "801231",
                BirthDate = new DateTime(1991, 10, 10),
                BirthPlace = "Ankara",
                FirstName = "Hasan",
                SurName = "Bilge",
                Gender = CORE.Enums.Gender.Male,
                EmailAddress = "hasanbilge@smail.com",
                Password = "1234",
                Role = Enums.Roles.Manager,
                Address = "Çalı Sok.",
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                PhoneNumber = "21200011150",
                Shift = Enums.Shifts.Vardiyasız,
                Hours = 8,
                HourlyPay = 100.00m,
                Days = 26,
                TotalPay = 26000.00m,
                Paid = true,
            });


            context.Employees.AddRange(employees);

            #endregion

            #region Müşteriler
            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                ID = c1,
                CustomerBookingID = cb1,
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

            #region Bokking 
            IList<Booking> bookings = new List<Booking>();

            bookings.Add(new Booking()
            {
                ID = boook1,
                CustomerBookingID =cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 2, 1),
                OutDate = new DateTime(2020, 5, 25),
                RoomID = room100,

            });

            bookings.Add(new Booking()
            {
                ID = boook2,
                CustomerBookingID = cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 3, 1),
                OutDate = new DateTime(2020, 3, 25),
                RoomID = room101,

            });

            bookings.Add(new Booking()
            {
                ID = boook3,
                CustomerBookingID = cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 4, 1),
                OutDate = new DateTime(2020, 5, 15),
                RoomID = room102,

            });

            bookings.Add(new Booking()
            {
                ID = boook4,
                CustomerBookingID = cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 4, 1),
                OutDate = new DateTime(2020, 4, 15),
                RoomID = room103,

            });

            bookings.Add(new Booking()
            {
                ID = boook5,
                CustomerBookingID = cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 2, 1),
                OutDate = new DateTime(2020, 4, 1),
                RoomID = room105,

            });

            bookings.Add(new Booking()
            {
                ID = boook6,
                CustomerBookingID = cb1,
                GeneralStatus = CORE.Enums.GeneralStatus.Active,
                Package = Enums.BookingPackages.AllInclusive,
                InDate = new DateTime(2020, 5, 1),
                OutDate = new DateTime(2020, 6, 1),
                RoomID = room105,

            });

            context.Bookings.AddRange(bookings);
            #endregion

            
            IList<CustomerBooking> customerBookings = new List<CustomerBooking>();

            customerBookings.Add(new CustomerBooking()
            {
                ID = cb1,
                BookingID = boook1,
                CustomerID = c1,           
            });

            context.CustomerBookings.AddRange(customerBookings);


            base.Seed(context);
        }
    }
}
