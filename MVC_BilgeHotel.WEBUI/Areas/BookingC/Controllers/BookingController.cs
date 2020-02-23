using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC.Controllers
{
    [CustomerAuthFilter]
    public class BookingController : Controller
    {
        BookingService sdb = new BookingService();
        RoomService rdb = new RoomService();
        Booking b = new Booking();
        CustomerBooking cb = new CustomerBooking();

        public ActionResult Index()
        {
            return View(sdb.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Booking model)
        {
            var customerUserDetail = Session["CLogin"] as Customer;
            b.ID = Guid.NewGuid();

            cb.ID = Guid.NewGuid();

            model.CustomerBookings = new List<CustomerBooking>()
            {
                new CustomerBooking {BookingID=b.ID,CustomerID = customerUserDetail.ID, ID = cb.ID}
            };

            //Kişi sayısı hesapa katılmamıştır.
            model.ID = b.ID;
            model.RoomID = rdb.GetByDefault(x => x.RoomNumber == "400").ID;
            DateTime dnow30 = DateTime.Now;
            dnow30 = dnow30.AddDays(30);

            DateTime dnow90 = DateTime.Now;
            dnow90 = dnow90.AddDays(90);

            TimeSpan Sonuc = model.OutDate - model.InDate;
            model.TotalDays = Sonuc.Days;
            model.UnitPrice = 100;
            if (model.InDate <= DateTime.Now)
            {
                return RedirectToAction("Index");
            }
            if (model.InDate < dnow30)
            {
                if (model.Package == MODEL.Enums.BookingPackages.AllInclusive)
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays);
                }
                else
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays);
                }
            }
            else if (model.InDate > dnow30 && model.InDate < dnow90)
            {

                if (model.Package == MODEL.Enums.BookingPackages.AllInclusive)
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.16m;
                }
                else
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.18m;
                }
            }

            else if (model.InDate > dnow90)
            {
                if (model.Package == MODEL.Enums.BookingPackages.AllInclusive)
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.23m;
                }
                else
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.23m;
                }
            }
            sdb.Add(model);
            return RedirectToAction("Index");
        }
    }
}