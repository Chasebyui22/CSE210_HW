class ChecklistGoal : Goal
{
    public int TargetCount;
    public int Bonus_points;
    public int TimesCompleted;
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus_points)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus_points = bonus_points;
        TimesCompleted = 0;
    }
    public override int RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted == TargetCount)
        {
            _isComplete = true;
            return _points + Bonus_points;
        }
        return _points;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{TargetCount}|{Bonus_points}|{TimesCompleted}|{_isComplete}";
    }
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {TimesCompleted}/{TargetCount}";
    }
}
