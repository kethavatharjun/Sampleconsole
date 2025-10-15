using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    //generate a method which takes two integers as input and returns their Prodcut upto the range
    /*
     * EG:
     * input(): 1,2,3,4,5
     * OUTPUT: 120 (1*2*3*4*5)
     * 
     * */
    public class ForLoopTest
    {
        public int CalculateProduct(int start, int end)
        {
            int productOfRangeNumber = 1;
            {
                for (int i = start; i <= end; i++)
                {

                    productOfRangeNumber *= i;

                }
            }
            return productOfRangeNumber;
        }



    }
}