using System;

class Lab3A
{
    static void Main(string[] args)
    {
        // Prompting the user for the current balance on the credit card
        Console.Write("Amount owed: $");
        double amountOwed = Convert.ToDouble(Console.ReadLine());

        // Prompting the user for the APR of the card
        Console.Write("APR: ");
        double apr = Convert.ToDouble(Console.ReadLine());

        // Converting APR from percent to decimal
        double aprDecimal = apr / 100;

        // Calculating the Monthly Percentage Rate
        double monthlyPercentageRate = aprDecimal / 12;

        // Calculating the minimum payment
        double minimumPayment = amountOwed * monthlyPercentageRate;

        // Displaying the results
        Console.WriteLine($"Monthly percentage rate: {monthlyPercentageRate * 100:F3}");
        Console.WriteLine($"Minimum payment: ${minimumPayment:F2}");
    }
}
