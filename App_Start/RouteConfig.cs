using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

// namespace Natural_Store.App_Start
namespace Natural_Store
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
        }
    }
}