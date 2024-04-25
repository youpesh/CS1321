using System;

class Lab6B
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int userNumber = 0;
        int guess;
        int numberOfGuesses = 0;

        Console.WriteLine("Pick a number between 1 and 1000:");

        // Validate user input
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userNumber))
            {
                if (userNumber >= 1 && userNumber <= 1000)
                {
                    break; // Break the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Number must be between 1 and 1000. Please try again:");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 1000:");
            }
        }

        // Start guessing
        do
        {
            // Generate a random number between 1 and 1000
            guess = rnd.Next(1, 1001); // The upper bound is exclusive, so it should be 1001
            Console.WriteLine("Guess: " + guess);
            numberOfGuesses++;
        }
        while (guess != userNumber);

        Console.WriteLine($"Number found: {userNumber} in {numberOfGuesses} guesses.");
    }
}