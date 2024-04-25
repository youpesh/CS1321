using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("How many games do you want to play?: ");
        int numGames = int.Parse(Console.ReadLine());

        string[] options = { "Rock", "Paper", "Scissors" };
        string[] results = new string[numGames];

        Random random = new Random();

        for (int i = 0; i < numGames; i++)
        {
            Console.Write($"Round {i + 1}: What do you want to throw?: ");
            string playerChoice = Console.ReadLine();
            string computerChoice = options[random.Next(0, 3)];

            Console.WriteLine($"Computer threw {computerChoice.ToUpper()}!");

            if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                (playerChoice == "Scissors" && computerChoice == "Paper") ||
                (playerChoice == "Paper" && computerChoice == "Rock"))
            {
                results[i] = "Player";
            }
            else if ((computerChoice == "Rock" && playerChoice == "Scissors") ||
                     (computerChoice == "Scissors" && playerChoice == "Paper") ||
                     (computerChoice == "Paper" && playerChoice == "Rock"))
            {
                results[i] = "Computer";
            }
            else
            {
                results[i] = "Tie";
            }
        }

        Console.WriteLine("Game Over...");
        Console.WriteLine("Here’s the recap:");

        for (int i = 0; i < numGames; i++)
        {
            Console.WriteLine($"{results[i]} won Round {i + 1}.");
        }
    }
}
