using System;

class Lab3B
{
    static void Main(string[] args)
    {
        float totalHours = 0;
        float totalQualityPoints = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Course {i} hours:");
            float hours = float.Parse(Console.ReadLine());

            Console.WriteLine($"Grade for course {i}:");
            float grade = float.Parse(Console.ReadLine());

            totalHours += hours;
            totalQualityPoints += hours * grade;
        }

        float gpa = totalQualityPoints / totalHours;

        Console.WriteLine($"Total hours is: {totalHours}");
        Console.WriteLine($"Total quality points is: {totalQualityPoints}");
        Console.WriteLine($"Your GPA for this semester is {gpa}");
    }
}
