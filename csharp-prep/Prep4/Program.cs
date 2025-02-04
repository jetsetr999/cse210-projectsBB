using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        int sumNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            // user input adding numbers to list
            Console.Write($"Enter number: ");
            string userInput = Console.ReadLine();
            // convert from string to integer
            userNumber = int.Parse(userInput);

            // creating total or sum of numbers
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                sumNumber = sumNumber + userNumber;
            }
        }

        // find average number
        Console.WriteLine($"The sum is: {sumNumber}");
        int listCount = numbers.Count;
        float avgNumber = sumNumber / listCount;
        Console.WriteLine($"The average is: {avgNumber} ");

        // find largest number
        int maxNumber = -1;
        for (int i = 0; i < numbers.Count; i++)
        {
            //Console.WriteLine(numbers[i]);

            if (maxNumber < numbers[i])
            {
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {maxNumber} ");

    }
}