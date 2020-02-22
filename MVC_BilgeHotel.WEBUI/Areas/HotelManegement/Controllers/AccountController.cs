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
    public class AccountController : Controller
    {
        EmployeeService db;

        public AccountController()
        {
            if (db == null)
            {
                db = new EmployeeService();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee model)
        {
            try
            {
                if (model.Password != null && model.EmailAddress != string.Empty)
                {
                    if (db.CheckEmpoyeeUsers(model.EmailAddress, model.Password, MODEL.Enums.Roles.Manager))
                    {
                        var employeeUser = db.GetByDefault(x => x.EmailAddress == model.EmailAddress);
                        Session["HMLogin"] = employeeUser;

                        var employeeUserDetail = Session["HMLogin"] as Employee;
                        TempData["EmployeeUser"] = employeeUserDetail.FirstName + " " + employeeUserDetail.SurName;

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz ve/veya Yekiniz Yok";
                    }
                }
                else
                {
                    TempData["Error"] = "Lütfen alanları boş bırakmayın";
                }
            }
            catch (Exception exp)
            {
                TempData["Error"] = exp.Message;
            }
            return RedirectToAction("Login");
        }

        [HotelMAuthFilter]
        public ActionResult Logout()
        {
            Session.Remove("HMLogin");
            return RedirectToAction("Login");
        }

        [HotelMAuthFilter]
        public ActionResult AccountDetail()
        {

            var employeeUserDetail = Session["HMLogin"] as Employee;
            TempData["EmployeeUser"] = employeeUserDetail.FirstName + " " + employeeUserDetail.SurName;
            
            return View(db.GetByID(employeeUserDetail.ID));
        }

        EmployeeService emps = new EmployeeService();

        [HotelMAuthFilter]
        [HttpPost]
        //TODO: DENECEK  [HotelMAuthFilter]
        public ActionResult AccountDetail(Employee model, HttpPostedFileBase ImagePath)
        {
            if (ModelState.IsValid)
            {
                //TODO: Düzenleme sırasında resim değişmediğinde resimi boş olarak değiştiriyor.
                model.ModifiedComputerName = Environment.MachineName;
                model.ModifiedComputerUsername = WindowsIdentity.GetCurrent().Name;
                model.ModifiedDate = DateTime.Now;

                if(model.ImagePath != null)
                {

                }
                else
                {
                    model.ImagePath = ImagesUploader.UploadSingleImage("~/Uploads/Img/Employee/", ImagePath);
                }
           
                model.TotalPay = ((model.Hours + model.EkstraHours) * model.HourlyPay) * model.Days;

                emps.Update(model);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}