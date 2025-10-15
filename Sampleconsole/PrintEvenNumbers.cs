using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class PrintEvenNumbers
    {
        public int PrintEvenNumbersRange(int start, int end)
        {
            int Even = start;
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            return Even;
        }
    }
}
