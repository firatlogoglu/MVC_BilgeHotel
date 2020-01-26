using System.Web.Mvc;

namespace MVC_BilgeHotel.WEBUI.Areas.HotelManegement
{
    public class HotelManegementAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HotelManegement";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HotelManegement_default",
                "HotelManegement/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}