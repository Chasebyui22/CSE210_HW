using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome(args);
        string name = PromptUserName(args);
        float number = PromptUserNumber(args);
        float square = SquareNumber(number);
        DisplayResult(square, name);
    }

    static void DisplayWelcome(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(string[] args)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static float PromptUserNumber(string[] args)
    {
        Console.Write("Please enter your favorite number: ");
        float number = int.Parse(Console.ReadLine());
        return number;
    }
    static float SquareNumber(float number)
    {
        float square = number * number;
        return square;
    }
    static void DisplayResult(float square, string name)
    {

        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}