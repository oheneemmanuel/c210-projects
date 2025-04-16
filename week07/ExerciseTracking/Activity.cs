using System.Security.Cryptography;

public abstract class Activity
{
    private DateTime _date;
    protected int _minutes; 

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    } 

    public abstract double GetDistance(); // Abstract method to be implemented in derived classes  
    public abstract double GetSpeed(); // Abstract method to be implemented in derived classes
    public abstract double GetPace(); // Abstract method to be implemented in derived classes   

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
    
}