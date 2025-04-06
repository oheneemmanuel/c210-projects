public class Activity 
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMesssage()
    {
        Console.WriteLine(_name)
    }


    
}