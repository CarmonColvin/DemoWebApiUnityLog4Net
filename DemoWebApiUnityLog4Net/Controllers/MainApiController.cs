using System;
using System.Web.Http;

namespace DemoWebApiUnityLog4Net.Controllers
{
    public class MainApiController : ApiController
    {
        /// <summary>
        /// GET: api/MainApi/
        /// </summary>
        /// <returns></returns>
        public String Get()
        {
            return @"You have reached MainApiController.Get()";
        }
    }
}
