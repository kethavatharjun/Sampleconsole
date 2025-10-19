using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class Pattern1
    {
        public void PatternRange1()
        {
            for (int i = 0; i <= 4; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    if(i >= j)
                    {
                        Console.Write("*", i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
