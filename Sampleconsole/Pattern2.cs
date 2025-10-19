using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class Pattern2
    {
        public void Pattern2Range()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (j >= 4 - i && j <= 4 + i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                }
        public static void Main(string[] args)
        {
            Pattern2 pattern = new Pattern2();
            pattern.Pattern2Range();
        }
    }
}