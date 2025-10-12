/*
Write a class with name as SumOfMoneyFromTwoFriends 
Method name SumOfMoney Which Takes Two Integers as input  and
prints to the Console How much is the Sum of Money from Two Friends
*/
//creat a class 
//class name as SumOfMoneyFromTwoFriends
//Method name is SumOfMoney
//Sum(int Frd1, Frd2) 
//Console.WriteLine("How much is the Sum of Money from Two Friends:");
using System.Runtime.InteropServices;

class SumOfMoneyFromTwoFriends
{
    public void SumOfMoney(int Frd1, int Frd2)
    {
        Console.WriteLine(Frd1 + Frd2);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How much is the Sum of Money From Two Friends:");
        //creating the object
        //class_name reference_name = new class name();
        SumOfMoneyFromTwoFriends test_ref = new SumOfMoneyFromTwoFriends();
        test_ref.SumOfMoney(25, 40);
    }
}