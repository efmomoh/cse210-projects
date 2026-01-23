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

        // find the average 
        float average = (float)total / num.Count;

        // find the maximum or highest number 
        int maximum_num = num[0];

        foreach (int numb in num)
        {
            if (numb > maximum_num)
            {
                maximum_num = numb;
            }
        }


        // find the minimun number 
        int min_num = num[0];
        foreach (int numb in num)
        {
            if (numb < min_num)
            {
                min_num = numb;
            }
        }

        // determining the smallest positive number 
        int smallestPositiveNumber = int.MaxValue;
        foreach (int numb in num)
        {
            if (numb > 0 && numb < smallestPositiveNumber)
            {
                smallestPositiveNumber = numb;
            }
        }

        // let's sort the numbers in the list 
        num.Sort();

        // and then let's finally print our output to the console 


        Console.WriteLine($"Total is : {total}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {maximum_num}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is:");

        // let's do a foreach loop to print out the sorted numbers 
        foreach(int numb in num)
        {
            Console.WriteLine(numb);
        }

    }
}