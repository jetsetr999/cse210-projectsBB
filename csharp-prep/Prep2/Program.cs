<<<<<<< Updated upstream
using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeValue = int.Parse(userInput);

        //Console.WriteLine(gradeValue);

       if (gradeValue >= 90)
       {
        letter = "A";
       }
        else if (gradeValue >= 80)
       {
        letter = "B";
       }
        else if (gradeValue >= 70)
       {
        letter = "C";
       }
        else if (gradeValue >= 60)
       {
        letter = "D";
       }
       else 
       {
        letter = "F";
       }

       Console.WriteLine($"Your grade is {letter} ");

       //if (letter == "A" || letter == "B" || letter == "C")
       if (gradeValue >= 70)
       {
        Console.WriteLine(" ----- Congratulations you passed ----- ");
       }
       else
       {
        Console.WriteLine("--- Sorry you failed seek help if needed and try again ---");
       }

       
    }
=======
using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeValue = int.Parse(userInput);

        //Console.WriteLine(gradeValue);

       if (gradeValue >= 90)
       {
        letter = "A";
       }
        else if (gradeValue >= 80)
       {
        letter = "B";
       }
        else if (gradeValue >= 70)
       {
        letter = "C";
       }
        else if (gradeValue >= 60)
       {
        letter = "D";
       }
       else 
       {
        letter = "F";
       }

       Console.WriteLine($"Your grade is {letter} ");

       //if (letter == "A" || letter == "B" || letter == "C")
       if (gradeValue >= 70)
       {
        Console.WriteLine(" ----- Congratulations you passed ----- ");
       }
       else
       {
        Console.WriteLine("--- Sorry you failed seek help if needed and try again ---");
       }

       
    }
>>>>>>> Stashed changes
}