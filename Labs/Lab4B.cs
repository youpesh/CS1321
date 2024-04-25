using System;

class Lab4B
{
    static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        string day = Console.ReadLine().ToLower();

        switch (day)
        {
            case "monday":
            case "wednesday":
                Console.WriteLine("I have class today!");
                break;
            case "friday":
                Console.WriteLine("It’s Friday! Friday! Gotta get down on Friday!");
                break;
            default:
                Console.WriteLine("I should use this time to do my homework.");
                break;
        }
    }
}
