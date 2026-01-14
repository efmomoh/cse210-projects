using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // call each functions in to the main 
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquareNumber);


        // define standalone functions 
        // display message and return none 
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program");
        }

        // Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Enter any number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Accepts an integer as a parameter and returns that number squared(as an integer)
        static int SquareNumber(int squareNumber)
        {
            int num = squareNumber * squareNumber;
            return num;
        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is: {number}");
        }
    }
}