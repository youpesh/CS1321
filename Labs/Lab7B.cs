using System;

class Lab7B
{
    public static void Main()
    {
        Console.Write("Please enter a value for the size: ");
        int size = int.Parse(Console.ReadLine()); 

        Console.WriteLine($"This is the requested {size}x{size} right-triangle:");

        for (int row = 1; row <= size; row++)
        {
            for (int star = 1; star <= row; star++)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }
    }
}
