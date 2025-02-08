<<<<<<< Updated upstream
using System;

class Program
{
    static void Main(string[] args)
    {
        // -- creating magic number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        // get user number
        // Console.Write("Guess what the magic number is (1 to 10)? ");

        // display results
        Console.WriteLine($"What is the magic number? {randomNumber} ");

        int userNumber = 0;

        while (userNumber != randomNumber)
        {
            Console.Write($"What is your guess? ");
            string userInput = Console.ReadLine();
            // convert from string to integer
            userNumber = int.Parse(userInput);

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 

    }
=======
using System;

class Program
{
    static void Main(string[] args)
    {
        // -- creating magic number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        // get user number
        // Console.Write("Guess what the magic number is (1 to 10)? ");

        // display results
        Console.WriteLine($"What is the magic number? {randomNumber} ");

        int userNumber = 0;

        while (userNumber != randomNumber)
        {
            Console.Write($"What is your guess? ");
            string userInput = Console.ReadLine();
            // convert from string to integer
            userNumber = int.Parse(userInput);

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 

    }
>>>>>>> Stashed changes
}