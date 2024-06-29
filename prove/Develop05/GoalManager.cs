class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string type = Console.ReadLine();
        Console.Write("What is the name of the goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?:  ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            case "4":
                newGoal = new NegativeGoal(name, description, points);
                break;
            default:
                return;
        }

        goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }
    public void ListGoals()
    {
        Console.WriteLine("\n The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"\nYou have {score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = File.CreateText(filename))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        goals.Clear();
        using (StreamReader reader = File.OpenText(filename))
        {
            score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                Goal goal = CreateGoalFromParts(parts);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }

    }
    private Goal CreateGoalFromParts(string[] parts)
    {
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[parts.Length - 1]);

        Goal goal = null;
        switch (type)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(name, description, points);
                break;
            case "EternalGoal":
                goal = new EternalGoal(name, description, points);
                break;
            case "ChecklistGoal":
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                goal = new ChecklistGoal(name, description, points, target, bonus);
                ((ChecklistGoal)goal).TimesCompleted = int.Parse(parts[6]);
                break;
            case "NegativeGoal":
                goal = new NegativeGoal(name, description, points);
                break;
        }

        if (goal != null)
        {
            goal._isComplete = isComplete;
        }

        return goal;
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter the number of the goal you accomplished: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = goals[index].RecordEvent();
        score += pointsEarned;
        if (goals[index] is NegativeGoal)
        {
            Console.WriteLine($"Oops! This is a negative goal. You lost {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        }
        Console.WriteLine($"You now have: {score} points.");
    }
}
