// Showing Creativity and Exceeding Requirements
// To show creativity and exceed requirements, we as a team decided to add two components:
    //  1. A Mood Tracker:      After the user answered the journal prompt, the program asks how the user is feeling.
    //                          This answer is then stored with the rest of the entry and can be saved/loaded to/from
    //                          the journal file.
    //  2. A Quote Generator:   After the user has answered both questions, the Journal Program displays a daily quote
    //                          randomly chosen from a collection of inspiring quotes. I decided against storing this
    //                          with the journal entry to keep it cleaner and easier readable.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";
        Console.WriteLine("\n***Welcome to the Journal Program!***");
        Console.WriteLine("***If you already have a Journal File and want to add to it, please load it first to prevent any data loss!***");

        do
        {
            Console.WriteLine("\nPlease select one of the following options by typing in the number:");
            Console.WriteLine("   1. Write");
            Console.WriteLine("   2. Display");
            Console.WriteLine("   3. Load");
            Console.WriteLine("   4. Save");
            Console.WriteLine("   5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                journal.WriteEntry();
            }

            else if(choice == "2")
            {
                journal.DisplayEntries();
            }

            else if(choice == "3")
            {
                journal.LoadEntries();
            }

            else if(choice == "4")
            {
                journal.SaveEntries();
            }

        } while (choice != "5");

        Console.WriteLine("\nGoodbye, see you soon!\n");
    }
}