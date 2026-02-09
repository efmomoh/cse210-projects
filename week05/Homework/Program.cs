using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // call the assignment class => super class
        Assignment assignment1 = new Assignment("Enssah Fayia Momoh", "CSE210");
        Console.WriteLine(assignment1.GetSummary());

        // call the MathAssignment class => sub class 1
        MathAssignment assignment2 = new MathAssignment("John Reading", "Programming with C#", "7.3", "8-9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());


        // call the WritingAssignment class => sub class 2
        WritingAssignment assignment3 = new WritingAssignment("Enssah Fayia Momoh", "Computer Science", "The Inventory of Information Technology");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}