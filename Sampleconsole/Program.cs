using Sampleconsole;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        SumOfNumbers sumOfNumbers = new SumOfNumbers();
        sumOfNumbers.CanculateSum();


        // Create an instance of ProductOfNumbers and call the method to calculate the product
        ProductOfNumbers productOfNumbers = new ProductOfNumbers();
        productOfNumbers.CanculateProduct();

        // Create an instance of ForLoopTest and call the method to calculate the product in a range
        ForLoopTest forLoopTest = new ForLoopTest();
        int result = forLoopTest.CalculateProduct(1, 5); // Example range from 1 to 5
        Console.WriteLine($"The product of numbers from 1 to 5 is: {result}");
        //Create an instance of ForLoopPractice and call the method to calculate the sum of multiplied numbers in a range
        ForLoopPractice forLoopPractice = new ForLoopPractice();
        int result1 = forLoopPractice.SumOfMultiplyOfEachNumberwithTwo(2, 5); // Example range from 2 to 5
        Console.WriteLine($"The sum of each number multiplied by 2 from 2 to 5 is: {result1}");
    }
}