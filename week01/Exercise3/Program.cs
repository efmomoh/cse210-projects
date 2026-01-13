using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        // determine magic numbers 
        Random randomGenerator = new Random();

        // declare while loop variable 
        string replayGame = "yes";

        while (replayGame.ToLower() == "yes")
        {
            // declare random number, guess and guess count variables variable 
            int number = randomGenerator.Next(1, 11);
            int guess = 0;
            int guessCount = 0;
            string word;

            // second while loop 
            while (guess != number)
            {
                // prompt user input 
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine()); // user input is store as string
                guessCount++;


                // if, else if , else statements 
                if (guess > number)
                {
                    word = "Higher";
                }
                else if (guess < number)
                {
                    word = "Lower";
                }
                else
                {
                    word = $"Congratulations! It took you {guessCount} time(s) to guess the MAGIC NUMBER.";

                }
                Console.WriteLine($"{word}!");

            }
            Console.Write("Do you want to REPLAY the game? Yes/No: ");
            replayGame = Console.ReadLine();

            if (replayGame.ToString() != "yes")
            {
                Console.WriteLine("Thank you for playing!");
            }

        }
    }
}
