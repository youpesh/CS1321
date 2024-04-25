using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[FYE Level Map Creator]");

        Console.Write("Enter a level map width: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter a level map height: ");
        int height = int.Parse(Console.ReadLine());

        char[,] levelMap = new char[height, width];

        // Initialize level
        for (int i = 0; i < levelMap.GetLength(0); i++)
        {
            for (int j = 0; j < levelMap.GetLength(1); j++)
            {
                levelMap[i, j] = '_';
            }
        }

        bool quit = false;
        while (!quit)
        {
            // Display map
            for (int i = 0; i < levelMap.GetLength(0); i++)
            {
                for (int j = 0; j < levelMap.GetLength(1); j++)
                {
                    Console.Write(levelMap[i, j]);
                }
                Console.WriteLine();
            }

            // Display menu
            Console.WriteLine("Options");
            Console.WriteLine("1. Clear Level");
            Console.WriteLine("2. Add Platform");
            Console.WriteLine("3. Add Items");
            Console.WriteLine("4. Quit");

            Console.Write("Enter a choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Clear Level
                    for (int i = 0; i < levelMap.GetLength(0); i++)
                    {
                        for (int j = 0; j < levelMap.GetLength(1); j++)
                        {
                            levelMap[i, j] = '_';
                        }
                    }
                    break;
                case 2:
                    // Add Platform
                    Console.WriteLine("[Add Platform]");
                    Console.Write("Enter X Coordinate: ");
                    int xPlatform = int.Parse(Console.ReadLine());
                    Console.Write("Enter Y Coordinate: ");
                    int yPlatform = int.Parse(Console.ReadLine());
                    Console.Write("Enter Length: ");
                    int length = int.Parse(Console.ReadLine());
                    if (xPlatform >= 0 && yPlatform >= 0 && yPlatform < height && xPlatform + length <= width)
                    {
                        for (int i = xPlatform; i < xPlatform + length; i++)
                        {
                            levelMap[yPlatform, i] = '=';
                        }
                    }
                    else
                    {
                        Console.WriteLine("This platform won’t fit in the level!");
                    }
                    break;
                case 3:
                    // Add Items
                    Console.WriteLine("[Add Item]");
                    Console.Write("Enter X Coordinate: ");
                    int xItem = int.Parse(Console.ReadLine());
                    Console.Write("Enter Y Coordinate: ");
                    int yItem = int.Parse(Console.ReadLine());
                    if (xItem >= 0 && yItem >= 0 && yItem < height && xItem < width)
                    {
                        levelMap[yItem, xItem] = 'P';
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid location!");
                    }
                    break;
                case 4:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
