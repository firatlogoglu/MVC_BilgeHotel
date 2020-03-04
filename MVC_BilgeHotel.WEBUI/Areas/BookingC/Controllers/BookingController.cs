using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using MVC_BilgeHotel.WEBUI.Models.VM;
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
        CustomerBookingService cbs = new CustomerBookingService();

        CustomerBooking cb = new CustomerBooking();

        public ActionResult Index()
        {
            var customerUserDetail = Session["CLogin"] as Customer;

            return View(sdb.FindBookings(customerUserDetail.ID));
        }

        public ActionResult Find()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FindRooms(RoomBookingVM roomBooking)
        {
            int inyear = roomBooking.InDate.Year;
            int inday = roomBooking.InDate.Day;
            int inmonth = roomBooking.InDate.Month;

            int outyear = roomBooking.OutDate.Year;
            int outday = roomBooking.OutDate.Day;
            int outmonth = roomBooking.OutDate.Month;

            DateTime dateTimeIn = new DateTime(inyear, inmonth, inday);
            DateTime dateTimeOut = new DateTime(outyear, outmonth, outday);

            TempData["InDate"] = dateTimeIn.ToString().Remove(10, 9);
            TempData["OutDate"] = dateTimeOut.ToString().Remove(10, 9);
            TempData["CostomerCount"] = roomBooking.CostomerCount;
            return View(sdb.EmptyRooms(roomBooking.InDate, roomBooking.OutDate, roomBooking.CostomerCount));
        }

        public ActionResult Create(RoomBookingVM room)
        {
            return View(sdb.GetByID(room.RoomID));
        }

        [HttpPost]
        public ActionResult Create(Booking model)
        {
            return RedirectToAction("Index");
        }

        public ActionResult CreateLast(Booking model)
        {
            b.ID = Guid.NewGuid();
            var customerUserDetail = Session["CLogin"] as Customer;


            cb.ID = Guid.NewGuid();

            model.CustomerBookings = new List<CustomerBooking>()
                {
                    new CustomerBooking {BookingID=b.ID,CustomerID = customerUserDetail.ID, ID = cb.ID}
                };

            //Kişi sayısı hesapa katılmamıştır.


            model.ID = b.ID;
            DateTime dnow30 = DateTime.Now;
            dnow30 = dnow30.AddDays(30);

            DateTime dnow90 = DateTime.Now;
            dnow90 = dnow90.AddDays(90);

            TimeSpan Sonuc = model.OutDate - model.InDate;
            model.TotalDays = Sonuc.Days;
            model.UnitPrice = 100;
            if (model.InDate <= DateTime.Now)
            {
                return RedirectToAction("Create");
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

        public ActionResult Detail(Booking book)
        {
            return View(sdb.GetByID(book.ID));
        }
    }
}