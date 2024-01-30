using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Mukesh", "multiplication", "Section 7.3", "Problem 5");
        System.Console.WriteLine(mathAssignment.GetHomeWorkList());
        System.Console.WriteLine();

        
        WritingAssignment writingAssignment = new WritingAssignment("Mahesh", "World War 2", "Role of Hitler in World War 2");
        System.Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}