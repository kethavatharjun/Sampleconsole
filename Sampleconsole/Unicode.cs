using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class Unicode
    {
        public char UnicodeValues()
        {
            char letter = 'a';
            for (int i = 65; i <= 90; i++)
            {
                letter = (char)i;
                Console.Write(letter+ " ");
            }
            return letter;
        }
    }
}
