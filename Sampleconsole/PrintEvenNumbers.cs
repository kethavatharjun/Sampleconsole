using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class PrintEvenNumbers
    {
        //print even number from range  1 to 20 which are greater than 10 and less than 18
        public int PrintEvenNumbersRange(int start, int end)
        {
            int EvenNumber = start;
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 2 == 0 && i>10 && i<18)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            return EvenNumber;
        }
        
    }
}