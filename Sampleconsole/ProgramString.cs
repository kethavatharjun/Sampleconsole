using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class ProgramString
    {
        public int ProgramStringRange(int start, int end)
        {
            string name = "My Name is Arjun";
            for(int i = start; i < end; i++)
            {
                name += " ";
                Console.Write(name[i]);
            }
            return name.Length;
        }
    }
}
