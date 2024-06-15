class Breathing : Activity
{
    public Breathing() : base("Breathing", "Take a deep breath", 0)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }
    private void BreathingAnimation()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Inhale for 4 seconds:");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 4; i++)
            {
                if (DateTime.Now >= endTime) break;
                Console.SetCursorPosition(0, 1);
                Console.WriteLine($"|{new string('#', i * 2).PadRight(8, ' ')}|");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 2);
            if (DateTime.Now <= endTime)
            {
                Console.WriteLine("Hold for 7 seconds:");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 1; i <= 7; i++)
            {
                if (DateTime.Now >= endTime) break;
                Console.SetCursorPosition(0, 3);
                Console.WriteLine($"|{new string('#', i * 2).PadRight(14, ' ')}|");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 4);
            if (DateTime.Now <= endTime)
            {
                Console.WriteLine("Exhale for 8 seconds:");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 8; i >= 1; i--)
            {
                if (DateTime.Now >= endTime) break;
                Console.SetCursorPosition(0, 5);
                Console.WriteLine($"|{new string('#',i).PadRight(8, ' ')}|");
                Thread.Sleep(1000);
            } 
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void PerformActivity()
    {
        StartMessage();
        BreathingAnimation();
        EndMessage();
    }
}