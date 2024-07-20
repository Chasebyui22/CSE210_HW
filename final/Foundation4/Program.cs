using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2024-20-07", 30, 2),
            new Cycling("1817-07-06", 45, 10),
            new Swimming("2009-15-01", 80, 100)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}