using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.Booking.Controllers
{
    [CustomerAuthFilter]
    public class HomeController : Controller
    {
        // GET: Booking/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}