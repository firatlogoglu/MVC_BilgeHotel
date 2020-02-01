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
    public class EmployeeController : Controller
    {
        EmployeeService emps = new EmployeeService();
        // GET: HotelManegement/Employee
        public ActionResult Index()
        {
            TempData["Employee"] = emps.GetAll();

            return View(emps.GetAll().ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee model, HttpPostedFileBase ImagePath)
        {
            model.ID = Guid.NewGuid();
            model.ImagePath = ImagesUploader.UploadSingleImage("~/Uploads/Img/Employee/", ImagePath);
            model.Password = Guid.NewGuid().ToString();
            model.TotalPay = ((model.Hours + model.EkstraHours) * model.HourlyPay) * model.Days;

            emps.Add(model);

            string message = $"Hoşgeldin {model.FirstName},\n\nBilge Hotel Sistemi geçici sifreniz:\n\n{model.Password}";

            MailSender.SendEmail(model.EmailAddress, message, "Sisteme Girşi Şifreniz");

            return RedirectToAction("Index");
        }

        public ActionResult Edit (Guid id)
        {
            return View(emps.GetByID(id));
        }


        [HttpPost]
        public ActionResult Edit (Employee model, HttpPostedFileBase ImagePath)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedComputerName = Environment.MachineName;
                model.ModifiedComputerUsername = WindowsIdentity.GetCurrent().Name;
                model.ModifiedDate = DateTime.Now;

                model.ImagePath = ImagesUploader.UploadSingleImage("~/Uploads/Img/Employee/", ImagePath);
                model.TotalPay = ((model.Hours + model.EkstraHours) * model.HourlyPay) * model.Days;

                emps.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete (Guid Id)
        {
            emps.Remove(emps.GetByID(Id));
            return RedirectToAction("Index");
        }
    }
}