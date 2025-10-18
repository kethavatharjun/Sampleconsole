using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class UnicodePattern
    {
        public int UnicodePatternRange()
        {
            int pattern = 'A';
         for( int i = 0; i <= 4; i++)
            {
                for ( int j = 0; j <= 4; j++)
                {
                    if ( i >= j)
                    {
                        Console.Write((char)('A' + i) + " ");
                    }
                }
                Console.WriteLine();
            }
         return pattern;
        }
    }
}