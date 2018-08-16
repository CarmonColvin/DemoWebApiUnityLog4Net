using System;
using System.Web.Http;
using DemoWebApiUnityLog4Net.Models;
using log4net;

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
        private ILog _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calc"></param>
        public MainApiController(ILog logger, ICalculator calc)
        {
            _logger = logger;
            _calc = calc;
        }

        /// <summary>
        /// GET: api/MainApi/
        /// </summary>
        /// <returns></returns>
        public String Get()
        {
            _logger.Info(@"MainApiController.Get() called");
            return $"You have reached MainApiController.Get() 2 + 2 = {_calc.Add(2,2)}";
        }
    }
}
