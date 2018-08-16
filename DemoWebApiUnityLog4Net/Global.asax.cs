using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using log4net;

namespace DemoWebApiUnityLog4Net
{
    /// <summary>
    /// 
    /// </summary>
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Initalize the logger so it is configured correctly
            var logger = LogManager.GetLogger(typeof(Global));
            logger.Info(@"Application started");
        }
    }
}
