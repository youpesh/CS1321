using System;

class Lab6C
{
    public static void Main()
    {
        decimal balance = 1000m; // Starting balance
        string userInput;
        do
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine($"You have ${balance} in your account.");
            Console.WriteLine("Menu");
            Console.WriteLine("0 – Make a deposit");
            Console.WriteLine("1 – Make a withdrawal");
            Console.WriteLine("2 – Display account value");
            Console.Write("Please make a selection: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0": // Deposit
                    Console.Write("How much would you like to deposit? : ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine($"Your current balance is ${balance}");
                    break;
                case "1": // Withdrawal
                    Console.Write("How much would you like to withdraw? : ");
                    decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                    if (withdrawalAmount <= balance)
                    {
                        balance -= withdrawalAmount;
                        Console.WriteLine($"Your current balance is ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds for this withdrawal.");
                    }
                    break;
                case "2": // Display balance
                    Console.WriteLine($"Your current balance is ${balance}");
                    break;
                default:
                    Console.WriteLine("Invalid entry, please try again.");
                    break;
            }

            Console.Write("Would you like to return to the main menu (Y/N)? : ");
            userInput = Console.ReadLine();
        } while (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase)); // Case-insensitive check for 'Y'

        Console.WriteLine("Thank you for banking with us!");
    }
}
