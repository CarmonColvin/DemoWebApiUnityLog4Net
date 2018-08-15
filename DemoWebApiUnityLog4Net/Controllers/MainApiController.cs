using System;
using System.Web.Http;
using DemoWebApiUnityLog4Net.Models;

namespace DemoWebApiUnityLog4Net.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class MainApiController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        private ICalculator _calc;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calc"></param>
        public MainApiController(ICalculator calc)
        {
            _calc = calc;
        }

        /// <summary>
        /// GET: api/MainApi/
        /// </summary>
        /// <returns></returns>
        public String Get()
        {
            return $"You have reached MainApiController.Get() 2 + 2 = {_calc.Add(2,2)}";
        }
    }
}
