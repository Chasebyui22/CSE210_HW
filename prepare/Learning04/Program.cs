using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Chase Smith", "Underwater Basket Weaving");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Chase Smith", "Calculus", "3.2", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Chase Smith", "Creative Writing", "The Best Story Ever");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}