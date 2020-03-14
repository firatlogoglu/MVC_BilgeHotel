using MVC_BilgeHotel.MODEL.Entities;
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
    public class HomeController : Controller
    {
        //TODO: Kampanya Veritabanı tablosu ve ilgi sayfa ve işlemler yapılacak.
        //TODO: İşten ayrılış işlemelerle ilgi sayfa tasarımı  yapılacak.
        //TODO: Maaş ödeme sayfası ve ödeme işlemeleri yapılacak.
        RoomService db = new RoomService();
        EmployeeService emps = new EmployeeService();

        public ActionResult Index(Room model)
        {
            return View(db.GetRoomEmtpy(model));
        }
    }
}