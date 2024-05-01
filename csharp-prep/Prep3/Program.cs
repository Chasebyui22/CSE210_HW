using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        float number = float.Parse(answer);
        Console.Write("What is your guess? ");
        string answers = Console.ReadLine();
        float guess = float.Parse(answers);
        if (number > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (number < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.Write("You got it!");
        }
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            answers = Console.ReadLine();
            guess = float.Parse(answers);
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You got it!");
            }
        } 
    }
}