using System;
using System.Web.Mvc;
using DemoWebApiUnityLog4Net.Models;
using log4net;

namespace DemoWebApiUnityLog4Net.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private ICalculator _calc;

        /// <summary>
        /// 
        /// </summary>
        private ILog _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calc"></param>
        public HomeController(ILog logger, ICalculator calc)
        {
            _logger = logger;
            _calc = calc;
        }

        // GET: Home
        public String Index()
        {
            _logger.Info(@"Logger Info() called from HomeController.Index()");
            return $"You have reached HomeController.Index(). 1 + 1 = {_calc.Add(1,1)}";
        }
    }
}
