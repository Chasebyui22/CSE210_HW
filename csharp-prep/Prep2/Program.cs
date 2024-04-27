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
        string letter = "";

        if (int.Parse(percentage) >= a)
        {
            letter = "A";
        }
        else if (int.Parse(percentage) >= aLow)
        {
            letter = "A -";
        }
        else if (int.Parse(percentage) >= bHigh)
        {
            letter = "B +";
        }
        else if (int.Parse(percentage) >= b)
        {
            letter = "B";
        }
        else if (int.Parse(percentage) >= bLow)
        {
            letter = "B -";
        }
        else if (int.Parse(percentage) >= cHigh)
        {
            letter = "C +";
        }
        else if (int.Parse(percentage) >= c)
        {
            letter = "C";
        }
        else if (int.Parse(percentage) >= cLow)
        {
            letter = "C -";
        }
        else if (int.Parse(percentage) >= dHigh)
        {
            letter = "D +";
        }
        else if (int.Parse(percentage) >= d)
        {
            letter = "D";
        }
        else if (int.Parse(percentage) >= dLow)
        {
            letter = "D -";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have an {letter}");

        if(int.Parse(percentage) >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("You shall not pass!");
        }
    }
}