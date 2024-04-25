using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("[Mathletes Game]");
        Console.Write("Choose a game mode (0=Easy, 1=Hard): ");
        int gameMode = int.Parse(Console.ReadLine());

        int totalQuestions = gameMode == 0 ? 3 : 6; // 3 questions for Easy, 6 for Hard
        int attempts = gameMode == 0 ? 3 : 1; // Unlimited retries for Easy, 1 attempt for Hard

        Random random = new Random();

        for (int i = 1; i <= totalQuestions; i++)
        {
            int num1, num2;
            if (gameMode == 0) // Easy mode: single-digit numbers
            {
                num1 = random.Next(-9, 10); // Range from -9 to 9
                num2 = random.Next(-9, 10);
            }
            else // Hard mode: full range
            {
                num1 = random.Next(-255, 256); // Range from -255 to 255
                num2 = random.Next(-255, 256);
            }

            int correctAnswer = num1 * num2;
            Console.WriteLine($"Q{i}. {num1} * {num2} = ?");

            bool answeredCorrectly = false;
            while (!answeredCorrectly && attempts > 0)
            {
                int playerAnswer = int.Parse(Console.ReadLine());
                if (playerAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    answeredCorrectly = true;
                }
                else
                {
                    attempts--;
                    if (gameMode == 0 && attempts > 0)
                    {
                        Console.WriteLine("Incorrect! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        if (gameMode == 1 || attempts == 0) // In Hard mode or no attempts left in Easy mode
                        {
                            Console.WriteLine("Game over...");
                            return;
                        }
                    }
                }
            }
            attempts = gameMode == 0 ? 3 : 1; // Reset attempts for Easy mode for the next question
        }

        Console.WriteLine("You win!");
    }
}
