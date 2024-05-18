using System;
// For my Creativity aspect I added another metric that entry keeps track of and it is a mood rating from 1 to 10 for the day.
// This could be used for statistical analysis of how your mood changes over time. Or just to see how our mood changes day to day.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

    do
    {
        Console.WriteLine("******************************");
        Console.WriteLine("* 1 Add entry                *");
        Console.WriteLine("* 2 Display entries          *");
        Console.WriteLine("* 3 Save entries             *");
        Console.WriteLine("* 4 Load entries             *");
        Console.WriteLine("* 5 Exit                     *");
        Console.WriteLine("******************************");
        Console.Write("Enter choice: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            journal.addEntry();
            Console.WriteLine("\n\n\n\n\n\n");
        }
        else if (choice == "2")
        {
            Console.WriteLine("");
            Console.WriteLine("Entries:");
            Console.WriteLine("");
            journal.displayEntries();
        }
        else if (choice == "3")
        {
            Console.Write("Enter filename to save:");
            string saveFile = Console.ReadLine();
            journal.SaveJournal(saveFile);
            Console.WriteLine("Saving entries...");
            Console.WriteLine("\n\n\n\n\n\n");
        }
        else if (choice == "4")
        {
            Console.Write("Enter filename to load:");
            string loadFile = Console.ReadLine();
            journal.LoadJournal(loadFile);
            Console.WriteLine("Loading entries...");
            Console.WriteLine("\n\n\n\n\n\n");
        }
        else if (choice == "5")
        {
            Console.WriteLine("Exiting...");
            exit = true;
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    } while (!exit);

        }
    }