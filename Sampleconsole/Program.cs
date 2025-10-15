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
    }
}