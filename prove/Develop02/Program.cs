using System;
using System.Collections.Generic;
namespace Journal4
{

    class Program
    {
        static void Main(string[] args)
        {
            // setup variables
            Journal entry = new Journal();
            // display menu choice
            string[] menu = { "  1 - New Journal Entry", "  2 - Display Journal Entries", "  3 - Save Journal to File", "  4 - Load Journal from file", "  5 - Quit" };
            foreach (string i in menu)
            {
                Console.WriteLine(i);
            }

            // get user menu choice
            Console.Write("What is your menu choice? ");
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            // menu selection and processing
            switch (userChoice)
            {

                case 1:
                    //  random quote question 
                    Console.WriteLine("New journal entry");
                    Prompt rQuote = new Prompt();
                    rQuote.DisplayQuotes();
                    Console.Write(">");
                    string journalEntry = Console.ReadLine();
                    entry._entry = journalEntry;
                    entry.DisplayEntries();
                    


                    break;
                case 2:
                    Console.WriteLine("Display journal entries ");
                    break;
                case 3:
                    Console.WriteLine("Save journal to a file");
                    //Journal file1 = new Journal(journalEntry);
                    //file1.SaveToFile = entry._journalDate + entry._journalEntry;

                    break;
                case 4:
                    Console.WriteLine("Load journal from file");
                    break;
                case 5:
                    Console.WriteLine("Quit journal");
                    break;

            }

        }
    }
}