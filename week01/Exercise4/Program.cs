using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // create a list variable
        List<int> num = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a list of numbers (type 0 when finished): ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                num.Add(userInput);

            }
        }

        // add the total using foreah loop 
        int total = 0;
        foreach (int number in num)
        {
            total += number;
        }

        Console.WriteLine($"Total is : {total}");

    }
}