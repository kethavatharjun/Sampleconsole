using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class RangeOfString
    {
        public string RangeOfStringRange()
        {
            string input = "My Village is far away";
            //print the substring fromrange of 2 to 8
            Console.Write("Substring from range of 2 to 8 is: ");
            for (int i = 2; i <= 8; i++)
            {
                Console.Write(input[i]);
            }

            return input;
        }
    }
}
