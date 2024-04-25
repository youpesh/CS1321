using System;

class Lab4C {
    static void Main(string[] args) {
        Console.WriteLine("Welcome!");
        Console.Write("Please input a number: ");

        // Read the user input and convert it to a double
        double number;
        if (double.TryParse(Console.ReadLine(), out number)) {
            bool exit = false;
            while (!exit) {
                // Display the menu options
                Console.WriteLine("\nWhat would you like to do to this number:");
                Console.WriteLine("0) Get the additive inverse of the number");
                Console.WriteLine("1) Get the reciprocal of the number");
                Console.WriteLine("2) Square the number");
                Console.WriteLine("3) Cube the number");
                Console.WriteLine("4) Exit the program");

                // Read the user's choice
                string choice = Console.ReadLine();

                // Process the choice using a switch statement
                switch (choice) {
                    case "0":
                        Console.WriteLine($"The additive inverse of {number} is {-number}");
                        break;
                    case "1":
                        Console.WriteLine(number != 0.0 ? $"The reciprocal of {number} is {1 / number}" : "Cannot divide by zero.");
                        break;
                    case "2":
                        Console.WriteLine($"The square of {number} is {Math.Pow(number, 2)}");
                        break;
                    case "3":
                        Console.WriteLine($"The cube of {number} is {Math.Pow(number, 3)}");
                        break;
                    case "4":
                        Console.WriteLine("Thank you, goodbye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again!");
                        break;
                }
            }
        } else {
            Console.WriteLine("Invalid input, please enter a valid number.");
        }
    }
}
