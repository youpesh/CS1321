using System;

class Lab7C
{
    static void Main()
    {
        Console.Write("Please enter a value for the size: ");
        int size = int.Parse(Console.ReadLine()); 

        Console.WriteLine($"This is the requested {size}x{size} right-triangle:");

        for (int row = 1; row <= size; row++)
        {
            for (int space = size - row; space > 0; space--)
            {
                Console.Write(" ");
            }
            for (int star = 1; star <= row; star++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();
        }
    }
}
