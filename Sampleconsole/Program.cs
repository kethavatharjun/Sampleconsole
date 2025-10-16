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
        //int result2 = evenNumbers.PrintEvenNumbersRange(1, 20);
        //int number = 2;
        //Console.WriteLine((number % 2 == 0) ? true : false);
        /*Write a program to read the value from the console and check if it is even
        if
        even
        Print the multiplication of the number.*/
        int even;
        Console.WriteLine("Enter a number:");
        even = Convert.ToInt32(Console.ReadLine());
        if (even % 2 == 0)
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{even} * {i} = {even * i}");
            }
        }
        else
        {
            Console.WriteLine("It's not an even number");
        }
    }
}