using System;

class Program
{
    // Method to find the maximum of two numbers
    public static int Max(int x, int y)
    {
        return x > y ? x : y;
    }

    // Method to find the minimum of two numbers
    public static int Min(int x, int y)
    {
        return x < y ? x : y;
    }

    // Method to find the average of two numbers
    public static double Average(int x, int y)
    {
        return (double)(x + y) / 2;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine());

      
        Console.WriteLine("Min is " + Min(num1, num2));
        Console.WriteLine("Max is " + Max(num1, num2));
        Console.WriteLine("Average is " + Average(num1, num2));
    }
}
