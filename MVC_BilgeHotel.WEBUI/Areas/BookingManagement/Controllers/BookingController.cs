﻿using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingManagement.Controllers
{
    //TODO: Yeni rezervasyon ekle ayarlanacak - Kişi ekleme - ODO - ödeme vs.
    //TODO: Çalışan kendi kişisel bilgilerini gösteme ve değiştirme sayfası yapılacak    
    //TODO: O GÜN AYRILACAK VE GİRİŞ YAPACA REZARFONLAR ANA SAYFADA GÖRÜTÜLE
    [BookingMAuthFilter]
    public class BookingController : Controller
    {
        BookingService sdb = new BookingService();
        CustomerBookingService cbs = new CustomerBookingService();
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
            //Kişi sayısı hesapa katılmamıştır.
            model.ID = Guid.NewGuid();
            TimeSpan Sonuc = model.OutDate - model.InDate;
            model.TotalDays = Sonuc.Days;
            model.UnitPrice = 100;
            if (model.Package == MODEL.Enums.BookingPackages.FullBoard && model.InDate > DateTime.Now.AddDays(30))
            {
                model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.16m;
            }
            else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive && model.InDate > DateTime.Now.AddDays(30))
            {
                model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.18m;
            }
            else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive && model.InDate > DateTime.Now.AddDays(120))
            {
                model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.23m;
            }
            else if (model.Package == MODEL.Enums.BookingPackages.FullBoard && model.InDate > DateTime.Now.AddDays(120))
            {
                model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.23m;
            }
            else if (model.Package == MODEL.Enums.BookingPackages.FullBoard)
            {
                model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays);
            }

            else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive)
            {
                model.TotalPrice = (model.UnitPrice * model.TotalDays);
            }
            sdb.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            return View(sdb.GetByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Booking model)
        {
            if (ModelState.IsValid)
            {
                model.TotalDays = (model.InDate.Day - model.OutDate.Day);
                model.UnitPrice = 100;
                if (model.Package == MODEL.Enums.BookingPackages.FullBoard && model.InDate > DateTime.Now.AddDays(30))
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.16m;
                }
                else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive && model.InDate > DateTime.Now.AddDays(30))
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.18m;
                }
                else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive && model.InDate > DateTime.Now.AddDays(120))
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays) * 0.23m;
                }
                else if (model.Package == MODEL.Enums.BookingPackages.FullBoard && model.InDate > DateTime.Now.AddDays(120))
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays) * 0.23m;
                }
                else if (model.Package == MODEL.Enums.BookingPackages.FullBoard)
                {
                    model.TotalPrice = ((model.UnitPrice + model.ExtraPrice) * model.TotalDays);
                }

                else if (model.Package == MODEL.Enums.BookingPackages.AllInclusive)
                {
                    model.TotalPrice = (model.UnitPrice * model.TotalDays);
                }

                model.ModifiedComputerName = Environment.MachineName;
                model.ModifiedComputerUsername = WindowsIdentity.GetCurrent().Name;
                model.ModifiedDate = DateTime.Now;

                sdb.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult BookingCustomers()
        {
            return View(cbs.GetAll().ToList());
        }
    }
}