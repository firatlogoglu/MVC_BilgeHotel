using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC.Controllers
{
    [CustomerAuthFilter]
    public class HomeController : Controller
    {
        BookingService sdb = new BookingService();
        // GET: BookingC/Home
        public ActionResult Index()
        {
            return View();
        }
        Customer cs1 = new Customer();



        public ActionResult BookingHistory()
        {
            return View();
        }
    }
}