class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    protected void Animation()
    {
        string[] spinner = { "/", "-", "\\", "|" };
    for (int i = 0; i < 4; i++)
        {
        foreach (var frame in spinner)
            {
            Console.Write(frame);
            Thread.Sleep(150);
            Console.Write("\b");
            }
        }
    }
    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How many seconds would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation();
        Console.WriteLine();
    }
    protected void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!");
        Console.WriteLine();
        Animation();
        Console.WriteLine($"You have spent {_duration} seconds on the {_name}.");
        Animation();
        Animation();
        Console.Clear();
    }
}