<<<<<<< Updated upstream
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        // variable functions 
        string userName = PromptUserName();
        int userNumber = PrompUserNumber();
        int sqrNumber = SquareNumber(userNumber);

        DisplayResult(userName, sqrNumber);

    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    
    //  Asks for and returns the user's favorite number (as an integer)
    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string userInput = Console.ReadLine();
        int uNumber = int.Parse(userInput);

        return uNumber;
    }

    // Accepts an integer as a parameter and returns 
    // that number squared (as an integer)
    static int SquareNumber(int uNumber)
    {
        int sqrNumber = uNumber * uNumber;

        return sqrNumber;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int sqrNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNumber}");
        
    }
=======
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        // variable functions 
        string userName = PromptUserName();
        int userNumber = PrompUserNumber();
        int sqrNumber = SquareNumber(userNumber);

        DisplayResult(userName, sqrNumber);

    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    
    //  Asks for and returns the user's favorite number (as an integer)
    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string userInput = Console.ReadLine();
        int uNumber = int.Parse(userInput);

        return uNumber;
    }

    // Accepts an integer as a parameter and returns 
    // that number squared (as an integer)
    static int SquareNumber(int uNumber)
    {
        int sqrNumber = uNumber * uNumber;

        return sqrNumber;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int sqrNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNumber}");
        
    }
>>>>>>> Stashed changes
}