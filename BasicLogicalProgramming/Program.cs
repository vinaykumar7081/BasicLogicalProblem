using System;
using BasicLogicalProgramming;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ********* Welcome in The Basic Logical Programming World ********");
        Console.WriteLine("flip coin number 1\n,Square of Two 2\n");
        bool check=true;
        while (check)
        { 
        Console.WriteLine("Please Enter the valid Number To Execution of the Program ");
            int option = Convert.ToInt32 (Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    percentage.FlipCoins();
                    break;
                case 2:
                    DisplayinSquare  square = new DisplayinSquare();
                    square.SquareOfTwo();
                    break;
                default : 
                    Console.WriteLine("Please Enter the valid Number to Execution the Your Program");
                    break;
            }
        }
    }
}