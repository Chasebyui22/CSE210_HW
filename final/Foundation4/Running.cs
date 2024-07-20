class Running : Activity {
    private double _distance;
    public Running(string date, float duration, double distance) : base("Running", date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / _duration) * 60;
    public override double GetPace() => _duration / _distance;

}