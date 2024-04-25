/* 
Class: CSE 1321L
Section: 01
Term: Spring
Instructor: John Blake
Name: Yousuf Bukhari
Lab#: 2
*/

using System;

class Lab2C
{
    static void Main()
    {
        Console.Write("Enter a width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.WriteLine($"The area is {area}");
        Console.WriteLine($"The perimeter is {perimeter}");
    }
}
