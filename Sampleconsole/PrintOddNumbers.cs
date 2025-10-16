/*write a program to print the odd number and 
     * if it is multiple of 3 from the range 2 to 20 
     * then print "I am Multiple of 3 and value is {num}"*/
    public class PrintOddNumbers
    {
        public int PrintOddNumbersRange(int a, int b)
        {
            int c = a;
            for (int i = 0; i < a; i++)
            {
             if(i%2!=0 && i % 3 == 0)
                {   
                    Console.WriteLine("I am Multiple of 3 and value is {0}", i);
                }
            }
            return c;
        }
    }
