using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("20 Jul 2024", 30, 2),
            new Cycling("07 Aug 1817", 45, 10),
            new Swimming("15 Jan 2009", 80, 100)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}