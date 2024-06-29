class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, -Math.Abs(points)) { }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) (Negative Goal)";
    }
}