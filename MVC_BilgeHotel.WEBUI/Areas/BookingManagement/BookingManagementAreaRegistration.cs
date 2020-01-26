using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingManagement
{
    public class BookingManagementAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BookingManagement";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BookingManagement_default",
                "BookingManagement/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}