using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.BookingC
{
    public class BookingCAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BookingC";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BookingC_default",
                "BookingC/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}