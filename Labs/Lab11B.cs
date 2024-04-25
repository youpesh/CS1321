using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        bool isLengthValid = password.Length >= 8;
        bool containsUppercase = false;
        bool containsDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                containsUppercase = true;
            }
            if (char.IsDigit(c))
            {
                containsDigit = true;
            }

            if (containsUppercase && containsDigit)
            {
                break;
            }
        }

        if (isLengthValid && containsUppercase && containsDigit)
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password");
        }

        Console.WriteLine("Program Ends");
    }
}