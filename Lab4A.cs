using System;

class Lab4A
{
    static void Main(string[] args)
    {
        Console.Write("Enter the score of your exam: ");
        double score = Convert.ToDouble(Console.ReadLine());
        string letterGrade = "";

        if (score >= 98 && score <= 100)
            letterGrade = "A+";
        else if (score >= 95 && score < 98)
            letterGrade = "A";
        else if (score >= 92 && score < 95)
            letterGrade = "A-";
        else if (score >= 89 && score < 92)
            letterGrade = "B+";
        else if (score >= 86 && score < 89)
            letterGrade = "B";
        else if (score >= 83 && score < 86)
            letterGrade = "B-";
        else if (score >= 80 && score < 83)
            letterGrade = "C+";
        else if (score >= 77 && score < 80)
            letterGrade = "C";
        else if (score >= 74 && score < 77)
            letterGrade = "C-";
        else if (score >= 71 && score < 74)
            letterGrade = "D+";
        else if (score >= 68 && score < 71)
            letterGrade = "D";
        else if (score >= 65 && score < 68)
            letterGrade = "D-";
        else if (score >= 0 && score < 65)
            letterGrade = "F";

        Console.WriteLine("Letter grade is: " + letterGrade);
    }
}
