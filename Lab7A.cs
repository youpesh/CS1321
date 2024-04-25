using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a value for the size: ");
        int size = int.Parse(Console.ReadLine());  // Reading the size from the user

        Console.WriteLine($"This is the requested {size}x{size} box:");

        // Outer loop for each line
        for (int i = 0; i < size; i++)
        {
            // Inner loop for each character in a line
            for (int j = 0; j < size; j++)
            {
                Console.Write("*");  // Print a star for each character in the box
            }
            Console.WriteLine();  // Move to the next line after printing a line of stars
        }
    }
}
