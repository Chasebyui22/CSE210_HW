class Listing: Activity
{
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }
    private string prompts()
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
    public void PerformActivity()
    {
        StartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = prompts();
        Console.WriteLine($"---{prompt}---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write("\b");
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("\b");
            Console.Write("> ");
            if (Console.ReadLine() != "")
            {
                itemCount++;
            }
        }
        Console.WriteLine($"You listed {itemCount} items!");
        EndMessage();
    }
}