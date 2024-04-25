using System;

class Program
{
    // Method to check if the array is sorted in non-decreasing order
    public static bool CheckIfSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    // Method to shuffle the array
    public static void ShuffleArray(int[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int randomIndex = rand.Next(array.Length);
            int temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }

    // Method to print the array
    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void Main(string[] args)
    {
        int[] array = new int[19];
        Random rand = new Random();

        // Fill the array with random values from 1 to 453
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 454);
        }

        Console.WriteLine("[Bogosort]");
        Console.WriteLine("Printing array...");
        PrintArray(array);

        int attempts = 0;
        while (!CheckIfSorted(array))
        {
            Console.WriteLine("Not sorted yet!");
            Console.WriteLine("Shuffling array...");
            ShuffleArray(array);
            Console.WriteLine("Printing array...");
            PrintArray(array);
            attempts++;
        }

        Console.WriteLine($"Hooray, it's sorted! And it only took {attempts} attempts!");
    }
}
