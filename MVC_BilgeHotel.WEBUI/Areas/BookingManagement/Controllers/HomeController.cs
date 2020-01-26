using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingManagement.Controllers
{
    [BookingMAuthFilter]

    public class HomeController : Controller
    {
        EmployeeService db;

        public HomeController()
        {
            if (db == null)
            {
                db = new EmployeeService();
            }
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}