using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> tallies = new();
       for (int i=0; i<=12; i++)
       {
            tallies.Add(0);
       }

       Console.WriteLine("Now rolling a billion pairs of dice....");
       Random randomGenerator = new Random();
       for (int roll=0; roll< 1000000000; roll++)
       {
        int die1 = randomGenerator.Next(1, 7);
        int die2 = randomGenerator.Next(1, 7);
        int total = die1 + die2; 
        tallies[total] ++;
       }
        Console.WriteLine("... finished rolling. Distribution graph: ");
        int scale = 5000000;
        for (int i=2; i<=12; i++)
        {
            Console.Write($"{i,2}:  ");
            for (int graphUnit=0; graphUnit < tallies[i]/scale; graphUnit++)
            {
                Console.Write("*");
            }
            Console.WriteLine($" ({tallies[i]:n0})");
        }
        Console.WriteLine($" (Scale: each # represents {scale:n0} rolls.)");

}
}
