using System;

class Program
{
    public static void Main(string[] args)
    {
        bool runAgain = true;

        while (runAgain)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0) Hello World");
            Console.WriteLine("1) Goodbye Moon");
            Console.WriteLine("2) Walking on Sunshine");
            Console.Write("What would you like to do: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Hello!");
                    break;
                case "1":
                    Console.WriteLine("Ok, bye.");
                    break;
                case "2":
                    Console.WriteLine("WHOA!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.Write("Type YES to rerun. ");
            string rerun = Console.ReadLine();

            // Use StringComparison.OrdinalIgnoreCase for comparison
            runAgain = rerun.Equals("yes", StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine("Program Ends");
    }
}