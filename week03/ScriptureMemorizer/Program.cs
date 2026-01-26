using System;


/*
EXCEEDING REQUIREMENTS:

To exceed the core requirements of this assignment, I added several creative features
to improve the scripture memorization experience.

First, the program works with a library or list of scriptures instead of a single hard-coded
scripture. Each time the program runs, it randomly selects a scripture from this list,
which helps users practice memorizing different scriptures rather than the same one
every time.

Second, the program gradually hides a small number of random words each time the user
presses ENTER. This simulates a real memorization challenge by slowly increasing
difficulty instead of hiding all words at once.

Third, I added a "play again" feature that allows the user to restart the program
without restarting the application. This makes the program more interactive and
user-friendly.

These enhancements demonstrate creativity, improve usability, and go beyond the
minimum assignment requirements.
*/

class Program
{
    static void Main(string[] args)
    {

        // ask user to play again 
        bool playAgain = true;

        // ask to play again user while loop => EXCEEDING REQUIREMENTS
        while (playAgain)
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

            // create a list of scriptures that reference scriptures randomly
            List<(Reference, string)> scriptures = new List<(Reference, string)>
            {
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding."),

            (new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten son."),

            (new Reference("Psalm", 3, 16), "The Lord is my shepherd I shall not want."),

            (new Reference("Jeremiah", 29, 19), "For I know the plans I have for you,” declares the LORD, “plans to prosper you and not to harm you, plans to give you hope and a future."),

            (new Reference("Philippians", 4, 13), "I can do everything through Him who gives me strength."),

            (new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love Him, who have been called according to His purpose."),

            (new Reference("Joshua", 1, 9), "Have I not commanded you? Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God will be with you wherever you go."),

            (new Reference("Romans", 12, 2), "Do not conform any longer to the pattern of this world, but be transformed by the renewing of your mind. Then you will be able to test and approve what God's will is—His good, pleasing and perfect will."),

            (new Reference("1 Corinthians", 13, 13), "And now these three remain: faith, hope and love. But the greatest of these is love.")
            };

            Random random = new Random();
            int index = random.Next(scriptures.Count);

            Reference reference = scriptures[index].Item1;
            string text = scriptures[index].Item2;

            Scripture scripture = new Scripture(reference, text);

            // declare the main while loop as the user interacts with the console
            while (!scripture.IsCompletelyHidden())
            {
                // clear the console after the program execution
                Console.Clear();

                Console.WriteLine(scripture.GetDisPlayText());
                Console.WriteLine();
                Console.Write("Please Press 'ENTER' to hide words or type 'quit' to exit the program: ");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                scripture.HideRandomWords(1);
            }

            // let's clear the console
            Console.Clear();
            Console.WriteLine("All words are completely hidden. Good job!");

            // ask user to play again => EXCEEDING REQUIREMENTS
            Console.WriteLine();
            Console.Write("Do you want to play again? (yes or no): ");
            string reply = Console.ReadLine().ToLower();

            if (reply != "yes")
            {
                playAgain = false;
            }

            Console.WriteLine("Thank you for playing scripture memorizer\n");
        }
    }

}
// <------------------THE END--------------------------------------------------------> 