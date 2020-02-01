using MVC_BilgeHotel.COMMON.Tools;
using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.HotelManegement.Controllers
{
    [HotelMAuthFilter]
    public class RoomController : Controller
    {
        RoomService rmdb = new RoomService();
        BookingRoomService BookingRoomService = new BookingRoomService();

        // GET: HotelManegement/Room
        public ActionResult Index()
        {
            return View(rmdb.GetAll().ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Room model, HttpPostedFileBase ImagePath)
        {
            model.ID = Guid.NewGuid();
            model.ImagePath = ImagesUploader.UploadSingleImage("~/Uploads/Img/Rooms/", ImagePath);

            rmdb.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            return View(rmdb.GetByID(id));

        }

        [HttpPost]
        public ActionResult Edit(Room model, HttpPostedFileBase ImagePath)
        {
            if (ModelState.IsValid)
            {
                model.ImagePath = ImagesUploader.UploadSingleImage("~/Uploads/Img/Rooms/", ImagePath);
                model.ModifiedComputerName = Environment.MachineName;
                model.ModifiedComputerUsername = WindowsIdentity.GetCurrent().Name;
                model.ModifiedDate = DateTime.Now;

                rmdb.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(Guid Id)
        {
            rmdb.Remove(rmdb.GetByID(Id));
            return RedirectToAction("Index");
        }
    }
}