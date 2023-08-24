using MVC_BilgeHotel.MODEL.Entities.VMs;
using MVC_BilgeHotel.SERVICE.Options;
using System.Collections.Generic;
using System.Web.Http;

namespace MVC_BilgeHotel.API.Controllers
{
    public class HomeController : ApiController
    {
        CustomerService s = new CustomerService();
        public IHttpActionResult GetFullRoomsCustomers()
        {
            List<CustomerVM> customerVMs = new List<CustomerVM>();
            var customer = s.FullRoomsCustomers();
            ushort s2 = 0;
            foreach (var item in customer)
            {
                CustomerVM c = new CustomerVM();
                c.ID = ++s2;
                c.TCNO = item.TCNO;
                c.FirstName = item.FirstName;
                c.SurName = item.SurName;
                c.BirthDate = item.BirthDate;
                c.BirthPlace = item.BirthPlace;
                c.Gender = item.Gender;
                c.MaritalState = item.MaritalState;
                c.PhoneNumber = item.PhoneNumber;
                c.Address = item.Address;
                c.BloodType = item.BloodType;
                customerVMs.Add(c);
            }
            return Ok(customerVMs);
        }
    }
}