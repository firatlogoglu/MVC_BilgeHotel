using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingManagement.Controllers
{
    [BookingMAuthFilter]
    public class HomeController : Controller
    {
        EmployeeService esdb;
        RoomService rmsdb;

        public HomeController()
        {
            if (esdb == null)
            {
                esdb = new EmployeeService();
            }

            if (rmsdb == null)
            {
                rmsdb = new RoomService();
            }
        }

        public ActionResult Index(Room model)
        {
            return View(rmsdb.GetRoomEmtpy(model));
        }
    }
}