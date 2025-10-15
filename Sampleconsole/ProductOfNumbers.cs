using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public  class ProductOfNumbers
    {
        public void CanculateProduct()
        {
            long product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product *= i;
            }
            Console.WriteLine($"The product of numbers from 1 to 10 is: {product}");
        }
    }
}
