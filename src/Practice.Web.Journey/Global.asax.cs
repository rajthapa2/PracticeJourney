using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web.Journey;

namespace Practice.Web.Journey
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(null,
            //                "{controller}/{action}",
            //                new
            //                    {
            //                        controller = "Car",
            //                        action = "Index"
            //                    }
            //    );




            routes.MapRoute("CarJourney", "car/{pageName}/{sectionName}",
                new
                {
                    controller = "Car",
                    action = "Index",
                    pageName = UrlParameter.Optional,
                    sectionName = UrlParameter.Optional
                });


            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Car", action = "Index", id = UrlParameter.Optional }
                );


        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }


    }
}