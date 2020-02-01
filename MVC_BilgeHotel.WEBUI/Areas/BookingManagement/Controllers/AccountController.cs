using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingManagement.Controllers
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

        // GET: BookingManagement/Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (Employee model)
        {
            try
            {
                if(model.Password != null && model.EmailAddress != string.Empty)
                {
                    if(db.CheckEmpoyeeUsers(model.EmailAddress, model.Password))
                    {
                        var employeeUser = db.GetByDefault(x => x.EmailAddress == model.EmailAddress);
                        Session["BMLogin"] = employeeUser;

                        var employeeUserDetail = Session["BMLogin"] as Employee;
                        TempData["EmployeeUser"] = employeeUserDetail.FirstName + " " + employeeUserDetail.SurName;

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz";
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

        [BookingMAuthFilter]
        public ActionResult Logout()
        {
            Session.Remove("BMLogin");
            return RedirectToAction("Login");
        }
    }
}