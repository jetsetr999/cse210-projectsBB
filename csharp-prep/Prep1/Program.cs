using System;

class Program
{
    static void Main(string[] args)
    {
              
<<<<<<< Updated upstream
       // start of user input
       Console.Write("What is your first name? ");
=======
        Console.Write("What is your first name? ");
>>>>>>> Stashed changes
        string fName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}