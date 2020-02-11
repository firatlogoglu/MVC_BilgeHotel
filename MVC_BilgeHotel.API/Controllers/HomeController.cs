using MVC_BilgeHotel.API.Models;
using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
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
        ProjectContext dp = new ProjectContext();
        RoomService rs = new RoomService();
        CustomerService s = new CustomerService();
        public IHttpActionResult GetOgrenciler()
        {
            //TODO:DOLU ODALAR YAPILACAK
            var customer = s.GetAll().Select(x => new CustomerVM
            {
                TCNO = x.TCNO,
                FirstName = x.FirstName,
                SurName = x.SurName,
                Address = x.Address,
                BirthDate = x.BirthDate,
                BirthPlace = x.BirthPlace,
                Gender = x.Gender,
                PhoneNumber = x.PhoneNumber,


            }).ToList();

            return Ok (customer);
        }
    }
}
