using System;
using System.IO;
//using System.ComponentModel.Design;

namespace journal
{

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "journalTest.txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }

        }
    }
}