class Cycling : Activity {
    private double _speed;
    public Cycling(string date, float duration, double speed) : base("Cycling", date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance() => (_speed * _duration) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}