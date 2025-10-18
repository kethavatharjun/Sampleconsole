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
        int result = forLoopTest.CalculateProduct(1, 5);

        Console.WriteLine($"The product of numbers from 1 to 5 is: {result}");
        //Create an instance of ForLoopPractice and call the method to calculate the sum of multiplied numbers in a range
        ForLoopPractice forLoopPractice = new ForLoopPractice();
        int result1 = forLoopPractice.SumOfMultiplyOfEachNumberwithTwo(2, 5);
        Console.WriteLine($"The sum of each number multiplied by 2 from 2 to 5 is: {result1}");

        //Create an instance of PrintEvenNumbers and call the method to calculate the sum of multiplied numbers in a range
        Console.WriteLine($"Even numbers are:");
        PrintEvenNumbers evenNumbers = new PrintEvenNumbers();
        int result2 = evenNumbers.PrintEvenNumbersRange(2, 20);

        PrintOddNumbers oddNumbers = new PrintOddNumbers();
        int result3 = oddNumbers.PrintOddNumbersRange(2, 20);

        MenuBasedProgram menuBasedProgram = new MenuBasedProgram();
        int result4 = menuBasedProgram.MenuBasedProgramChoice();

        RangeOfString rangeOfString = new RangeOfString();
        rangeOfString.RangeOfStringRange();

        Unicode unicode = new Unicode();
        char result5 = unicode.UnicodeValues();

        UnicodePattern unicodePattern = new UnicodePattern();
        int the = unicodePattern.UnicodePatternRange();
    }
}