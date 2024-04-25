using System;
using System.Threading; // Required for Thread.Sleep()

class Program
{
    static void Main()
    {
        Console.WriteLine("[Backspace Animation]");
        Console.Write("Please enter your sentence: ");
        string sentence = Console.ReadLine();  // Getting the full sentence from the user

        Console.Write("How many letters do you want to backspace? ");
        int backspaceCount = int.Parse(Console.ReadLine());  // Getting the number of characters to erase

        Console.Write(sentence);  // Displaying the sentence

        // Loop for backspacing the specified number of characters
        for (int i = 0; i < backspaceCount; i++)
        {
            Console.Write("\b \b");  // Erasing one character at a time
            Thread.Sleep(500);  // Pausing for half a second to create the animation effect
        }
    }
}
