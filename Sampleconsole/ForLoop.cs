using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class ForLoop
    {
        //access_specifiers = public, private, protect,default
        //retun type = void, int, string, float.
        //Method name
        //parameters
        // access_specifier return_type Methodname(parameters);
        public int Sum(int x, int y) 
        {
            int sum = x+y;
            {
                Console.WriteLine(sum);
            }
            return sum;
           
        }
       
         //drive code  
    public static void Main(string[] args)
        {
           //Console.WriteLine("hello world");
           // //Object_creation 
           // //class_name reference_name = new class_name();
           // ForLoop name = new ForLoop();
           // //method calling
           // int result = name.Sum(2, 3);
            ProgramString programString = new ProgramString();
            int result1 = programString.ProgramStringRange(11, 16);
        }
    }
}
