public abstract class Goal
{
    protected string _shortName;
    protected string _description;

    protected int _points;

    public Goal(string ShortName, string description, int points)
    {
        _shortName = ShortName;
        _description = description;
        _points = points;
    }
    public  abstract void RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetails()
    {
        return $"[{(IsComplete() ? "X" : "")}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }
    
}