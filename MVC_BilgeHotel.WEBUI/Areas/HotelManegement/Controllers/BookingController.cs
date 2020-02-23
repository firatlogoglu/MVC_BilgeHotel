using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.HotelManegement.Controllers
{
    [HotelMAuthFilter]
    public class BookingController : Controller
    {
        BookingService bsdb = new BookingService();

        public ActionResult Index()
        {
            return View();
        }
    }
}