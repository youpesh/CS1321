using System;

class Lab6A {
  public static void Main (string[] args) {
    
    int largestNumber = int.MinValue;

    Console.WriteLine("Please enter 10 numbers and this program will display the largest.");

    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"Please enter number {i}: ");
        int number = int.Parse(Console.ReadLine());

        if (number > largestNumber)
        {
            largestNumber = number; 
        }
    }

    Console.WriteLine($"The largest number was {largestNumber}");
    
  }
}