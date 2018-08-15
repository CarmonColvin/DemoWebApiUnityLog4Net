using System;

namespace DemoWebApiUnityLog4Net.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public Int32 Add(Int32 param1, Int32 param2)
        {
            return param1 + param2;
        }
    }
}
