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
        Console.Write("Enter a Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("Sum of all even numbers between 1 to {0} = {1}", number, sum);
    }
}