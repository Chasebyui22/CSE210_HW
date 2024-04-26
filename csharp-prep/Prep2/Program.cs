using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 93;
        int aLow = 90;
        int bHigh = 87;
        int b = 83;
        int bLow = 80;
        int cHigh = 77;
        int c = 73;
        int cLow =70;
        int dHigh = 67;
        int d = 63;
        int dLow =60;
        int f = 59;

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        
        if (int.Parse(percentage) > a)
        {
            Console.WriteLine("You have an A");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > aLow)
        {
            Console.WriteLine("You have an A -");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > bHigh)
        {
            Console.WriteLine("You have an B +");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > b)
        {
            Console.WriteLine("You have an B");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > bLow)
        {
            Console.WriteLine("You have an B -");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > cHigh)
        {
            Console.WriteLine("You have an C +");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > c)
        {
            Console.WriteLine("You have an C");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > cLow)
        {
            Console.WriteLine("You have an C -");
            Console.WriteLine("You passed the course");
        }
        else if (int.Parse(percentage) > dHigh)
        {
            Console.WriteLine("You have an D +");
            Console.WriteLine("You did not pass the course");
        }
        else if (int.Parse(percentage) > d)
        {
            Console.WriteLine("You have an D");
            Console.WriteLine("You did not pass the course");
        }
        else if (int.Parse(percentage) > dLow)
        {
            Console.WriteLine("You have an D -");
            Console.WriteLine("You did not pass the course");
        }
        else
        {
            Console.WriteLine("You have an F");
            Console.WriteLine("You did not pass the course");
        }
    
    }
}