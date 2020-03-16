using MVC_BilgeHotel.MODEL.Context;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using MVC_BilgeHotel.MODEL.Entities.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC.Controllers
{
    //TODO: TOP LEFT GİBİ DÜZENLEM İŞLEMLERİ YAPILACAK (Tasarım iyileştirilecek)
    //TODO: Müşteri kişisel bilgilerini gösteme ve değiştirme sayfası yapılacak
    //TODO: Ödeme sayfaları yapılacak

    [CustomerAuthFilter]
    public class BookingController : Controller
    {
        BookingService sdb = new BookingService();
        RoomService rdb = new RoomService();
        Booking b = new Booking();
        CustomerBookingService cbs = new CustomerBookingService();

        CustomerBooking cb = new CustomerBooking();
        CustomerService cdb = new CustomerService();

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
            model.AddCostomerCount = 1;

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

        public ActionResult Details(Booking book)
        {
            return View(sdb.GetByID(book.ID));
        }

        public ActionResult BookingCustomers(Guid id)
        {
            string data;
            if (TempData["BookingCustomerSuccessful"] != null)
                data = TempData["BookingCustomerSuccessful"] as string;

            TempData.Keep();

            var dd = sdb.FindcustomerBookings(id);
            return View(dd);
        }
        public ActionResult FindCustomer(CustomerBookingsVM customerBookingsVM)
        {
            ViewBag.BID = customerBookingsVM.BookingID;

            string data;
            if (TempData["BookingCustomerError"] != null)
                data = TempData["BookingCustomerError"] as string;

            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult FindAddCustomer(CustomerBookingsVM customerBookingsVM)
        {
            ViewBag.BID = customerBookingsVM.BookingID;

            if (cbs.CheckBookingCustomer(customerBookingsVM.TCNO, customerBookingsVM.BookingID))
            {
                TempData["BookingCustomerError"] = "Lütfen başka bir T.C No yazın, bu kişi rezervasyonda bulunuyor";

                return RedirectToAction("FindCustomer", "Booking", new { customerBookingsVM.BookingID });
            }
            else
            {
                var TCNO = cdb.GetByDefault(x => x.TCNO == customerBookingsVM.TCNO);
                if (TCNO == null)
                {
                    Customer cus = new Customer();
                    cus.TCNO = customerBookingsVM.TCNO;
                    cus.FirstName = customerBookingsVM.FirstName;
                    cus.SurName = customerBookingsVM.SurName;
                    cus.BirthDate = customerBookingsVM.BirthDate;
                    cus.BirthPlace = customerBookingsVM.BirthPlace;
                    cus.Gender = customerBookingsVM.Gender;
                    cus.BloodType = customerBookingsVM.BloodType;
                    cus.MaritalState = customerBookingsVM.MaritalState;

                    cus.PhoneNumber = customerBookingsVM.PhoneNumber;
                    cus.Address = customerBookingsVM.Address;
                    cus.EmailAddress = customerBookingsVM.EmailAddress;

                    cus.User = false;

                    if (ModelState.IsValid)
                    {
                        if (cdb.CheckCustomerTCNO(cus.TCNO))
                        {
                            ViewBag.TC = "TCNO DAHA ÖNCE KAYITLARIMIZA GİRDİ";

                            //TODO:Gereksiz alan
                            cdb.TCUpdate(cus);

                            return View(customerBookingsVM);
                        }

                        if (cdb.CheckCustomerTCNOs(cus.TCNO))
                        {
                            //TODO:Gereksiz alan
                            ViewBag.TC = "TCNO DAHA ÖNCE KAYITLARIMIZA GİRDİ";
                            return View(customerBookingsVM);
                        }

                        else if (cdb.CheckEmailAd(cus.EmailAddress))
                        {
                            //TODO:Gereksiz alan
                            ViewBag.ExistsEmail = "Email daha önce kayıt edilmiş.";
                            return View(customerBookingsVM);
                        }
                        else
                        {
                            cus.ID = Guid.NewGuid();
                            cdb.Add(cus);

                            CustomerBooking cb = new CustomerBooking();
                            cb.ID = Guid.NewGuid();
                            cb.CustomerID = cus.ID;
                            cb.BookingID = customerBookingsVM.BookingID;
                            cbs.Add(cb);

                            b = sdb.GetByID(customerBookingsVM.BookingID);
                            b.AddCostomerCount = b.AddCostomerCount + 1;
                            sdb.Update(b);

                            TempData["BookingCustomerSuccessful"] = cus.FirstName + " " + cus.SurName + " " + "Hotel kaytılarına eklendi. Rezevasyona başarılı bir şekilde eklen.";
                            return RedirectToAction("BookingCustomers", new { ID = cb.BookingID });
                        }
                    }
                    else
                    {
                        return View(customerBookingsVM);
                    }
                }
                else
                {
                    CustomerBooking cb = new CustomerBooking();
                    cb.ID = Guid.NewGuid();
                    cb.CustomerID = TCNO.ID;
                    cb.BookingID = customerBookingsVM.BookingID;
                    cbs.Add(cb);

                    b = sdb.GetByID(customerBookingsVM.BookingID);
                    b.AddCostomerCount = b.AddCostomerCount + 1;
                    sdb.Update(b);

                    TempData["BookingCustomerSuccessful"] = customerBookingsVM.FirstName + " " + customerBookingsVM.SurName + " " + "Hotel kaytılarında mevcut. Rezevasyona başarılı bir şekilde eklen. <br /> Kimlik bilgilerinin doğruluğunu lütfen kontroller ediniz.";
                    return RedirectToAction("BookingCustomers", "Booking", new { ID = b.ID });
                }
            }
        }
    }
}