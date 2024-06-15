using System;
// For showing creativity I made a cool breathing animation with different colors to help you track your breathing.
class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.PerformActivity();
                    break;
                case "2":
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.PerformActivity();
                    break;
                case "3":
                    Listing listingActivity = new Listing();
                    listingActivity.PerformActivity();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
}