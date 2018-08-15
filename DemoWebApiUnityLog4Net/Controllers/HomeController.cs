using System;
using System.Web.Mvc;
using DemoWebApiUnityLog4Net.Models;

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
        /// <param name="calc"></param>
        public HomeController(ICalculator calc)
        {
            _calc = calc;
        }

        // GET: Home
        public String Index()
        {
            return $"You have reached HomeController.Index(). 1 + 1 = {_calc.Add(1,1)}";
        }
    }
}
