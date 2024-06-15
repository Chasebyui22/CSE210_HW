class Reflection : Activity
{
    public Reflection() : base("Reflection", "Reflect on your day", 0)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }
    private string RandomPrompt()
    {
        string[] prompts = new string[] {"Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
    private void DisplayQuestions()
    {
        string[] questions = {
            "> Why was this experience meaningful to you?",
            "> Have you ever done anything like this before?",
            "> How did you get started?",
            "> How did you feel when it was complete?",
            "> What made this time different than other times when you were not as successful?",
            "> What is your favorite thing about this experience?",
            "> What could you learn from this experience that applies to other situations?",
            "> What did you learn about yourself through this experience?",
            "> How can you keep this experience in mind in the future?"
        };

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            foreach (string question in questions)
            {
                if (DateTime.Now > endTime)
                {
                    break;
                }
                Console.WriteLine(question);
                Animation();
                if (DateTime.Now > endTime)
                {
                    break;
                }
                Animation();
                if (DateTime.Now > endTime)
                {
                    break;
                }
                Animation();
                if (DateTime.Now > endTime)
                {
                    break;
                }
                Animation();
            }
        }
    }
    public void PerformActivity()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {RandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        if (Console.ReadLine() == "")
        {
            Console.Write("You may begin in: ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write("\b");
                Console.Write($"{i}");
                Thread.Sleep(1000);
            }
            DisplayQuestions();
        }
        EndMessage();
    }
}