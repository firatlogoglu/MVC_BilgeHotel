using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Filters.AuthorizationFilters
{
    public class HotelMAuthFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["HMLogin"] == null)
            {
                filterContext.Result = new RedirectResult("~/HotelManegement/Account/Login");
            }
        }
    }
}