using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters
{
    public class CustomerAuthFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["CLogin"] == null)
            {
                filterContext.Result = new RedirectResult("~/Booking/Account/Login");
            }
        }
    }
}