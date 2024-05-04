using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        List<float> numbers = new();
        float number = float.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }
        float sum = 0;
        foreach (int amount in numbers)
        {
            sum += amount;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        float largest = numbers[0];
        foreach (int amount in numbers)
        {
            if (amount > largest)
            {
                largest = amount;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}