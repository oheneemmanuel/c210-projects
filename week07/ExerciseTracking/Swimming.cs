public class Swimming : Activity
{
    private double _laps; // Number of laps swum
    

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
        
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return (double)_minutes / GetDistance(); // Pace in min/mile
    }
}