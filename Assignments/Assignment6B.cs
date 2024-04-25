using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for the type of data they want to sort
        Console.WriteLine("[Overloaded Sort]");
        Console.Write("What data type do you want to enter? (int, char, float) ");
        string dataType = Console.ReadLine().ToLower();

        // Use a switch statement to handle different data types
        switch (dataType)
        {
            case "int":
                int[] intArray = new int[8];
                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    intArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                ArraySort(intArray);
                break;

            case "char":
                char[] charArray = new char[8];
                for (int i = 0; i < charArray.Length; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    charArray[i] = Console.ReadLine()[0]; // Taking the first character of the input
                }
                ArraySort(charArray);
                break;

            case "float":
                float[] floatArray = new float[8];
                for (int i = 0; i < floatArray.Length; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    floatArray[i] = float.Parse(Console.ReadLine());
                }
                ArraySort(floatArray);
                break;

            default:
                Console.WriteLine("Invalid data type.");
                break;
        }
    }

    // Overloaded ArraySort method for int array
    static void ArraySort(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("The sorted integer values are:");
        Console.WriteLine(string.Join(", ", array));
    }

    // Overloaded ArraySort method for char array
    static void ArraySort(char[] array)
    {
        Array.Sort(array);
        Console.WriteLine("The sorted char values are:");
        Console.WriteLine(string.Join(", ", array));
    }

    // Overloaded ArraySort method for float array
    static void ArraySort(float[] array)
    {
        Array.Sort(array);
        Console.WriteLine("The sorted float values are:");
        Console.WriteLine(string.Join(", ", array));
    }
}
