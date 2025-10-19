using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class SquarePattern
    {
        public void SquarePatternRange()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                    Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
