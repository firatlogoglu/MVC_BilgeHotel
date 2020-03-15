using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class CustomerService : BaseService<Customer>
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public bool CheckCustomerUsers(string _email, string _password)
        {
            return Any(x => x.EmailAddress == _email && x.Password == _password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tcno">TC Kimlik No'su giriniz</param>
        /// <returns></returns>
        public bool CheckCustomerTCNO(string _tcno)
        {
            return Any(x => x.TCNO == _tcno && x.User == false);
        }

        public bool CheckCustomerTCNOs(string _tcno)
        {
            return Any(x => x.TCNO == _tcno && x.User == true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_email">E-Posta Adresini Giriniz</param>
        /// <returns></returns>
        public bool CheckEmailAd(string _email)
        {
            return Any(x => x.EmailAddress == _email);
        }

        public List<Customer> FullRoomsCustomers()
        {
            List<Customer> customers = new List<Customer>();

            var sonuc = db.Rooms.Where(x => x.RoomStatus == MODEL.Enums.RoomStatus.Full).Join(
            db.Bookings,
            rm => rm.ID,
            b => b.RoomID,
            (rom, bk) => new { rom, bk })

             .Join(
             db.CustomerBookings,
             bk => bk.bk.ID,
             c => c.BookingID,
             (bkk, cbb) => new { bkk.bk, cbb.CustomerID }).Where(x => x.bk.Entry == true)

             .Join(db.Customers,
             cb => cb.CustomerID,
             c => c.ID,
             (cb, c) => new { c.TCNO, c.FirstName, c.SurName, c.BirthDate, c.BirthPlace, c.Gender, c.PhoneNumber, c.Address, c.BloodType });

            foreach (var item in sonuc)
            {
                Customer customer = new Customer();
                customer.TCNO = item.TCNO;
                customer.FirstName = item.FirstName;
                customer.SurName = item.SurName;
                customer.BirthDate = item.BirthDate;
                customer.BirthPlace = item.BirthPlace;
                customer.Gender = item.Gender;
                customer.BloodType = item.BloodType;
                customer.PhoneNumber = item.PhoneNumber;
                customer.Address = item.Address;
                customers.Add(customer);
            };

            return (customers);
        }
    }
}
