/* 
Class: CSE 1321L
Section: 01
Term: Spring
Instructor: John Blake
Name: Yousuf Bukhari
*/

using System;

class Assignment2B
{
    public static void Main(string[] args)
    {
        // Grabs values
        Console.WriteLine("Enter the hit box bottom-left X coordinate:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the hit box bottom-left Y coordinate:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the height of the hit box:");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the width of the hit box:");
        int height = Convert.ToInt32(Console.ReadLine());

        int bottomLeftX = x;
        int bottomLeftY = y;
        int topLeftX = x;
        int topLeftY = y + height;
        int bottomRightX = x + width;
        int bottomRightY = y;
        int topRightX = x + width;
        int topRightY = y + height;

        Console.WriteLine("[Hit Box Coordinates]");
        Console.WriteLine($"Bottom-Left: {bottomLeftX}, {bottomLeftY}");
        Console.WriteLine($"Top-Left: {topLeftX}, {topLeftY}");
        Console.WriteLine($"Bottom-Right: {bottomRightX}, {bottomRightY}");
        Console.WriteLine($"Top-Right: {topRightX}, {topRightY}");
        
    }
}