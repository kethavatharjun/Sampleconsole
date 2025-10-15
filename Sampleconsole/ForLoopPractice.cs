using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program while developing new class and generate method new as SumOfMultiplyOfEachNumberwithTwo

*withing the Range on  2 to 5 and return the value*/
namespace Sampleconsole
{
    public class ForLoopPractice
    {
        public int SumOfMultiplyOfEachNumberwithTwo(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i * 2;
            }
            return sum;
        }
    }
}