using System;

class Program
{
    public static bool IsValid(double width, double height)
    {
        return (width + height) > 30;
    }

    public static double Area(double width, double height)
    {
        return width * height;
    }

    public static double Perimeter(double width, double height)
    {
        return 2 * (width + height);
    }

    public static void Main(string[] args)
    {
        char continueProgram;
        do
        {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (IsValid(width, height))
            {
                Console.WriteLine("This is a valid rectangle");
                Console.WriteLine("The area is: " + Area(width, height));
                Console.WriteLine("The perimeter is: " + Perimeter(width, height));
            }
            else
            {
                Console.WriteLine("This is an invalid rectangle");
            }

            Console.Write("Do you want to enter another width and height (Y/N)? : ");
            continueProgram = Convert.ToChar(Console.ReadLine());

        } while (continueProgram == 'Y' || continueProgram == 'y');

        Console.WriteLine("Program Ends");
    }
}
