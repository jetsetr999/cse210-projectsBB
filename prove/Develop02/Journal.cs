<<<<<<< Updated upstream
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Threading;

namespace Journal4
{

    public class Journal
    {

        public string _entry;
        public string _quote;

        public List<Journal> _entryList = new List<Journal>();


        public static void FileJournal()
        {
            DateTime cDate = DateTime.Today;

            string fileName = "jornal25.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{cDate}");
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"transfer data eludes me ");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "violet";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }
        public static void DisplayEntries()
        {
            Console.WriteLine($"test diplay");

        }

    }
=======
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Threading;

namespace Journal4
{

    public class Journal
    {

        public string _entry;
        public string _quote;
         

        DateTime cDate = DateTime.Today;
        
        public List<Journal> _entryList = new List<Journal>();


        public static void _journalEntry()
        {

            string fileName = "jornal25.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"date and time elude me ");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
 

        }
        

        public static void _displayEntries()
        {

        }

    }
>>>>>>> Stashed changes
}