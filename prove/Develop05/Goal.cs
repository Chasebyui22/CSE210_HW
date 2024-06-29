abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public bool _isComplete;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract string GetDetailsString();
}