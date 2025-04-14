using System.Drawing;

public class SimpleGoal : Goal

{
    public bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    public override void RecordEvent()

    {
        if (!_isComplete)
        {
            Console.WriteLine($"You have earned {_points} points!");
            _isComplete = true;
            
        }
        else 
        {
            Console.WriteLine("You have already completed this goal!");
            
        }
        
        
    }
    public void SetComplete(bool Complete)
    {
        _isComplete = Complete;
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }   

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}