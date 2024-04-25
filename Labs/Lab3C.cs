using System;

class Lab3C
{
    static void Main()
    {
        Console.Write("Enter the number of quarters: ");
        int quarters = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of dimes: ");
        int dimes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of nickels: ");
        int nickels = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of pennies: ");
        int pennies = int.Parse(Console.ReadLine());

        Console.WriteLine($"You entered {quarters} quarters.");
        Console.WriteLine($"You entered {dimes} dimes.");
        Console.WriteLine($"You entered {nickels} nickels.");
        Console.WriteLine($"You entered {pennies} pennies.");

        int totalCents = quarters * 25 + dimes * 10 + nickels * 5 + pennies;
        int dollars = totalCents / 100;
        int cents = totalCents % 100;

        Console.WriteLine($"Your total is {dollars} dollars and {cents} cents.");
    }
}
