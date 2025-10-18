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
            char letter = '0';
            for (int i = 97; i <= 122; i++)
            {
                letter = (char)i;
                Console.Write(letter+ " ");
            }
            return letter;
        }
    }
}
