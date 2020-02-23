using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Options;
using MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC.Controllers
{
    public class AccountController : Controller
    {
        CustomerService db;
        public AccountController()
        {
            if (db == null)
            {
                db = new CustomerService();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customer model)
        {
            try
            {
                if (model.Password != null && model.EmailAddress != string.Empty)
                {
                    if (db.CheckCustomerUsers(model.EmailAddress, model.Password))
                    {
                        var customerUser = db.GetByDefault(x => x.EmailAddress == model.EmailAddress);
                        Session["CLogin"] = customerUser;

                        var customerUserDetail = Session["CLogin"] as Customer;
                        TempData["CustomerUser"] = customerUserDetail.FirstName + " " + customerUserDetail.SurName;
                        TempData["CustomerID"] = customerUserDetail.ID;
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        TempData["Error"] = "Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz";
                    }
                }
                else
                {
                    TempData["Error"] = "Lütfen boş alan bırakmayın";
                }
            }
            catch (Exception exp)
            {
                TempData["Error"] = exp.Message;
            }
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                if (db.CheckCustomerTCNO(model.TCNO))
                {
                    //TODO: KULLANICI OLUP OLMADIĞIN AYARLANMADI
                    //TODO: KULLANICINI ÖNCEKİ DURUMUNU GÖSTER

                    ViewBag.TC = "TCNO DAHA ÖNCE KAYITLARIMIZA GİRDİ";

                    db.TCUpdate(model);

                    //db.GetByID(db.GetByID).GeneralStatus = CORE.Enums.GeneralStatus.Deleted;

                    return View();
                }

                if (db.CheckCustomerTCNOs(model.TCNO))
                {
                    ViewBag.TC = "TCNO DAHA ÖNCE KAYITLARIMIZA GİRDİ";
                    return View();
                }

                else if (db.CheckEmailAd(model.EmailAddress))
                {
                    ViewBag.ExistsEmail = "Email daha önce kayıt edilmiş.";
                    return View();
                }
                else
                {
                    model.ID = Guid.NewGuid();
                    model.User = true;
                    db.Add(model);

                    return RedirectToAction("RegisterSuccess", "Account");
                }
            }
            else
            {
                return View();
            }
        }

        [CustomerAuthFilter]
        public ActionResult RegisterSuccess()
        {
            return View();
        }

        [CustomerAuthFilter]
        public ActionResult Logout()
        {
            Session.Remove("CLogin");
            return RedirectToAction("Login");
        }
    }
}