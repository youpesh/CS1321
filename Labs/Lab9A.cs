using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];

        Console.WriteLine("Please enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("What is the target number: ");
        int target = Convert.ToInt32(Console.ReadLine()); 
      
        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("The target is in the set.");
        }
        else
        {
            Console.WriteLine("The target is not in the set.");
        }
    }
}