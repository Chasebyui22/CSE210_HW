abstract class Activity {
    protected string _name;
    protected string _date;
    protected float _duration;
    
    public Activity(string name, string date, float duration) {
        _name = name;
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_name} ({_duration} min) - " +
               $"Distance {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}