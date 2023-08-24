using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC.Controllers
{
    [CustomerAuthFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BookingHistory()
        {
            return View();
        }
    }
}