using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole
{
    public class MenuBasedProgram
    {
        public int MenuBasedProgramChoice()
        {
            int choice = 0;

            Console.WriteLine(" MENU BASED PROGRAM ");
            Console.WriteLine("1. Addition of Two Numbers");
            Console.WriteLine("2. Subtraction of Two Numbers");
            Console.WriteLine("3. Find Maximum of Two Numbers");
            Console.WriteLine("4. Print Numbers in a Range");
            Console.Write("Enter your choice (1-4): ");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Entered choice is: 1.Addition of Two Numbers");
                    Console.Write("Enter first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Addition of Two Numbers Is = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Entered choice is: 2.Subtraction of Two Numbers");
                    Console.Write("Enter first number: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Subtraction of two numbers is = " + (c - d));
                    break;

                case 3:
                    Console.WriteLine("Entered choice is: 3. Find Maximum of Two Numbers");
                    Console.Write("Enter first number: ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int f = Convert.ToInt32(Console.ReadLine());
                    if (e > f)
                        Console.WriteLine("Maximum = " + e);
                    else if (f > e)
                        Console.WriteLine("Maximum = " + f);
                    else
                        Console.WriteLine("Both are equal");
                    break;

                case 4:
                    Console.WriteLine("Entered choice is: 4. Print Numbers in a Range");
                    Console.Write("Enter start of range: ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter end of range: ");
                    int end = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numbers in the given range:");
                    for (int i = start; i <= end; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                    break;
                   
            }
            return choice;
        }
    }
}
