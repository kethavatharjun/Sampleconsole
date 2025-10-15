using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public  class SumOfNumbers
    {
        public void CanculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}");
        }
    }
}
