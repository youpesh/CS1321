/* 
Class: CSE 1321L
Section: 01
Term: Spring
Instructor: John Blake
Name: Yousuf Bukhari
Lab#: 2
*/

using System;

class Lab2A
{
    static void Main()
    {
        Console.Write("Enter a name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter another name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();

        Console.Write("Enter an adverb: ");
        string adverb = Console.ReadLine();

        string madLib = $"Once upon a time, there was a person named {name1} who had a child named {name2}. " +
                                $"This child would {verb} {adverb} while singing to strangers.";
        Console.WriteLine(madLib);
    }
}

