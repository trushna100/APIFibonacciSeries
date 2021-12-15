using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibAPI.Services
{
    public class FibonacciService
    {
        public FibonacciService() { }

        /// <summary>
        /// Iterative approach to display the Fibonacci series
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public List<int> GetSequence(int len)
        {
            
            if(len < 1)
            {
                return new List<int>();
            }

            int a = 0, b = 1;
            if (len == 1)
            {
                return new List<int> { a };
            }

            
            var result = new List<int>(len) { a, b };

            if (len == 2) 
            { 
                return result;
            }
           
            for (int i = 2; i < len; i++)
            {
                var c = a + b;
                result.Add(c);
                a = b;
                b = c;
            }

            return result;
        }
    }
}
