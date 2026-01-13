using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // grade program
        // print to the console 
        Console.Write("What is your score? ");

        // ask user for input and store as a string variable
        string userGrade = Console.ReadLine();

        // Convert the string into an integer 
        int score = int.Parse(userGrade);

        // declare variable 
        string letter;

        // Handle the letter cases 
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }



        // determine the sign 
        int lastDigit = score % 10;
        string sign;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // # handle exceptions of (A+, F+ AND F-)
        if (score >= 93)
            sign = "";

        if (letter == "F")
            sign = "";

        // print score 
        if (score >= 70)
        {
            Console.Write($"Your score is: {letter}{sign}. Congratulations! You have successfully passed.");
        }
        else
        {
            Console.Write($"Failed. Your score is {letter}{sign}. Please try again...");
        }
    }
}