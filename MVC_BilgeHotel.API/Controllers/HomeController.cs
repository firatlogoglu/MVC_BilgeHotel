﻿using MVC_BilgeHotel.API.Models;
using MVC_BilgeHotel.SERVICE.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_BilgeHotel.API.Controllers
{
    public class HomeController : ApiController
    {
        CustomerService s = new CustomerService();
        public IHttpActionResult GetFullRoomsCustomers()
        {
            //TODO:DOLU ODALAR YAPILACAK

            List<CustomerVM> customerVMs = new List<CustomerVM>();
            var customer = s.FullRoomsCustomers();
            ushort s2 = 0;
            foreach (var item in customer)
            {
                CustomerVM c = new CustomerVM();
                c.ID = ++ s2;
                c.TCNO = item.TCNO;
                c.FirstName = item.FirstName;
                c.SurName = item.SurName;
                c.BirthDate = item.BirthDate;
                c.BirthPlace = item.BirthPlace;
                c.Gender = item.Gender;
                c.PhoneNumber = item.PhoneNumber;
                c.Address = item.Address;
                customerVMs.Add(c);
            }
            return Ok(customerVMs);
        }
    }
}
