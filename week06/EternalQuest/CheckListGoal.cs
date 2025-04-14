public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have completed {_amountCompleted} out of {_target} tasks. You have earned {_points} points!");
            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You have completed the goal and earned an additional {_bonus} bonus points!");
                 // Assuming you have a method to add bonus points
            }
            
        }
        else
        {
            Console.WriteLine("You have already completed this goal!");
            
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

}