using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16, 3, 17);
        Scripture scripture1 = new Scripture(reference1, "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. 17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        Reference reference2 = new Reference("2 Nephi", 25, 26);
        Scripture scripture2 = new Scripture(reference2, "26 And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
        Reference reference3 = new Reference("Mosiah", 2, 17);
        Scripture scripture3 = new Scripture(reference3, "17 And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        Reference reference4 = new Reference("Philippians", 4, 13);
        Scripture scripture4 = new Scripture(reference4, "13 I can do all things through Christ which strengtheneth me.");
        Reference reference5 = new Reference("Ether", 12, 6);
        Scripture scripture5 = new Scripture(reference5, "6 And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.");
        
        while (true)
        {
            Console.WriteLine("Type a number to choose a scripture:");
            Console.WriteLine("1) " + reference1.GetReference());
            Console.WriteLine("2) " + reference2.GetReference());
            Console.WriteLine("3) " + reference3.GetReference());
            Console.WriteLine("4) " + reference4.GetReference());
            Console.WriteLine("5) " + reference5.GetReference());
            Console.WriteLine("Type 'quit' to exit.");

            string choice = Console.ReadLine();
            if (choice.ToLower() == "quit")
            {
                break;
            }

            Scripture currentScripture = null;

            switch (choice)
            {
                case "1":
                    currentScripture = scripture1;
                    break;
                case "2":
                    currentScripture = scripture2;
                    break;
                case "3":
                    currentScripture = scripture3;
                    break;
                case "4":
                    currentScripture = scripture4;
                    break;
                case "5":
                    currentScripture = scripture5;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Returning to menu.");
                    continue;
            }

            while (true)
            {
                currentScripture.Display();

                if (currentScripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Returning to menu.");
                    break;
                }

                Console.WriteLine("Press Enter to hide more words or type 'menu' to return to the menu.");
                string input = Console.ReadLine();
                
                if (input.ToLower() == "menu")
                {
                    break;
                }

                currentScripture.HideWords();
            }
        }
    }
}
