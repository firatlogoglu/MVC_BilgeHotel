using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    if (db.CheckEmpoyeeUsers(model.EmailAddress, model.Password))
                    {
                        var employeeUser = db.GetByDefault(x => x.EmailAddress == model.EmailAddress);
                        Session["HMLogin"] = employeeUser;

                        var employeeUserDetail = Session["HMLogin"] as Employee;
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
    }
}