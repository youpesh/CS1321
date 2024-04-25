using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Minesweeper – Simplified Edition]");
        Console.Write("What is the grid size? ");
        int gridSize = int.Parse(Console.ReadLine());

        char[,] grid = new char[gridSize, gridSize];
        int[] mines = new int[gridSize];

        // Initialize the grid and place mines
        Random rand = new Random();
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                grid[i, j] = '?';
            }
            mines[i] = rand.Next(gridSize); // Randomly place a mine in each column
        }

        // Game loop
        bool gameOver = false;
        while (!gameOver)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("Enter your X coordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter your Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            // Check for mine
            if (mines[y] == x)
            {
                grid[x, y] = 'X';
                gameOver = true;
                Console.WriteLine("Sorry, you hit a mine!");
            }
            else
            {
                grid[x, y] = '_';
                // Check for win
                int safeCount = 0;
                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (grid[i, j] == '_')
                        {
                            safeCount++;
                        }
                    }
                }
                if (safeCount == gridSize * gridSize - gridSize) // All safe spots are cleared
                {
                    gameOver = true;
                    Console.WriteLine("You win!");
                }
            }
        }

        // Final grid display
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(grid[i, j]);
            }
            Console.WriteLine();
        }
    }
}
