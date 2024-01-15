using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        int percentage = int.Parse(Console.ReadLine());
        string grade;
        string sign;

       
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (percentage % 10 < 3 && percentage >= 60)
        {
            sign = "-";
        }
        else if (percentage % 10 >= 7 && percentage >= 60)
        {
            sign = "+";
        }
        else
        {
            Console.WriteLine(percentage % 10);
            sign = "";
        }

        Console.WriteLine($"Your grade is {sign}{grade}");
        if (percentage < 70)
        {
            Console.WriteLine($"You couldn't pass the class!");
        }
        else
        {
            Console.WriteLine("Hey congratulations for passing!");
        }
    }
}