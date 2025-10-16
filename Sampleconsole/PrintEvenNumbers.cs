using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class PrintEvenNumbers
    {
        /*Write a C# program to find the sum of all even numbers between 1 and a given number N
         * , using only one for loop."*/

        public int PrintEvenNumbersRange(int start, int end)
        {
            int EvenNumber = start;
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 2 != 0 && i % 3 == 0)
                    {
                        Console.WriteLine($"I am Multiple of 3 and value is {i}");
                    }
                }
            }
            return EvenNumber;
        }

    }
}