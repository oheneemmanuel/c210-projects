public  class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _minutes; // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in mph
    }

    public override double GetPace()
    {
        return (double)_minutes / GetDistance(); // Pace in min/mile
    }
}