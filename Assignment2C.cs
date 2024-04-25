/* 
Class: CSE 1321L
Section: 01
Term: Spring
Instructor: John Blake
Name: Yousuf Bukhari
*/

using System;

class Assignment2C
{
    public static void Main(string[] args)
    {
        const double UsdToGbp = 0.79;
        const double GbpToBisonDollar = 1.0 / 5.0;
        
        Console.WriteLine("Welcome to Bisonica!");

        Console.WriteLine("How many US Dollars do you have?");
        int dollars = Convert.ToInt32(Console.ReadLine());

        double britishPounds = dollars * UsdToGbp;
        double bisonDollars = britishPounds * GbpToBisonDollar;

        Console.WriteLine($"{dollars} US Dollar(s) is {britishPounds:F2} British Pound(s),");
        Console.WriteLine($"which is {bisonDollars:F2} Bison Dollar(s)!");

    }
}