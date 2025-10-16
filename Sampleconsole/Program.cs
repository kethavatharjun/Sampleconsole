using Sampleconsole;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //SumOfNumbers sumOfNumbers = new SumOfNumbers();
        //sumOfNumbers.CanculateSum();


        //// Create an instance of ProductOfNumbers and call the method to calculate the product
        //ProductOfNumbers productOfNumbers = new ProductOfNumbers();
        //productOfNumbers.CanculateProduct();

        //// Create an instance of ForLoopTest and call the method to calculate the product in a range
        //ForLoopTest forLoopTest = new ForLoopTest();
        //int result = forLoopTest.CalculateProduct(1, 5); // Example range from 1 to 5
        //Console.WriteLine($"The product of numbers from 1 to 5 is: {result}");
        ////Create an instance of ForLoopPractice and call the method to calculate the sum of multiplied numbers in a range
        //ForLoopPractice forLoopPractice = new ForLoopPractice();
        //int result1 = forLoopPractice.SumOfMultiplyOfEachNumberwithTwo(2, 5); // Example range from 2 to 5
        //Console.WriteLine($"The sum of each number multiplied by 2 from 2 to 5 is: {result1}");
        ////Create an instance of PrintEvenNumbers and call the method to calculate the sum of multiplied numbers in a range 
        //Console.WriteLine($"Even numbers are:");
        //PrintEvenNumbers evenNumbers = new PrintEvenNumbers();
        //int result2 = evenNumbers.PrintEvenNumbersRange(2, 20);
        //PrintOddNumbers oddNumbers = new PrintOddNumbers();
        //int result3 = oddNumbers.PrintOddNumbersRange(2, 20);
        //int number = 2;s
        //Console.WriteLine((number % 2 == 0) ? true : false);
        /*Write a C# program to find the sum of all even numbers between 1 
         * and a given number N, using only one for loop..*/
        /*Write a program to to showcase the use of switch case

        input as string IsPaymentDone which can be true of false value it can hold.

        if true then print  to Console like "Payment is Done"
        if false then print -->"Payment is Pending"*/
        //bool IsPaymentDone;
        //IsPaymentDone = Convert.ToBoolean(Console.ReadLine()); //false!=null <--true
        //switch (IsPaymentDone)
        //{
        //    case true:
        //        Console.WriteLine("Payment is done");
        //        break;
        //    case false:
        //        Console.WriteLine("Payment is Pending");
        //        break;
        //}
        /*develop a menu based program using switch case
         * EG:
         * switch case shold allow integer as number 
         * if number is 1 then code related to Addition of Two Number
         * if number is 2 then Subtraction of Number
         * 3 then maximum of element
         * 4 then  code related to the printing of numbers in between the range*/
            int choice;

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
    }
}