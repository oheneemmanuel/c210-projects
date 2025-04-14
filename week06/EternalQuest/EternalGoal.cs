public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points!");
        
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}