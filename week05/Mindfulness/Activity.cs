public class Activity 
{
    public string _name;
    public string _description;
    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMesssage()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    
        
    }
    public void DisplayEndidngMessage(int duration)
    {
        Console.WriteLine("Well Done");
        Console.WriteLine($"You have completed another {duration} seconds of this activity. Good Job");

    }
    public void ShowSpinner(int duration)
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|",  "/", "-", "\\"};
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < EndTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();
    }
}