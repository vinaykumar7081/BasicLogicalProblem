using System;
using BasicLogicalProgramming;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ********* Welcome in The Basic Logical Programming World ********");
        Console.WriteLine("flip coin number 1\n Square of Two 2\n Leap Year 3\n Harmonic Number 4\n Prime Factor 5\n Quotient and Remainder 6\n");
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
                case 3:
                    LeapYear  year = new LeapYear();
                   year.LeapYears();
                    break;
                case 4:
                    HarmonicNumbers  number = new HarmonicNumbers();
                    number.HarmonicNumber();
                    break;
                case 5:
                   PrimeFactor factor = new PrimeFactor ();
                    factor.PrimeFactors ();
                    break;
                case 6:
                    QuotientAndRemainder numbers = new QuotientAndRemainder ();
                    numbers.RemienderAndQuotient();
                    break;
                default : 
                    Console.WriteLine("Please Enter the valid Number to Execution the Your Program");
                    break;
            }
        }
    }
}