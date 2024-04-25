/* 
Class: CSE 1321L
Section: 01
Term: Spring
Instructor: John Blake
Name: Yousuf Bukhari
*/

using System;

class assignment2A
{
    public static void Main(string[] args)
    {
        // Grabs values
        Console.WriteLine("Enter a number you want to find a multiple of:");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int value2 = Convert.ToInt32(Console.ReadLine());

        int remainder = value2 % value1;
        int nearestMultiple = value2 - remainder;
        Console.WriteLine($"The nearest multiple of {value1} from {value2} is {nearestMultiple}!");
 
    }
}