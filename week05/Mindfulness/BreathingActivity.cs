public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void StartActivity()
    {
        DisplayStartingMesssage();

        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        PerformActivity(duration);

    }
    public void PerformActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        Console.WriteLine("Activity starting in ...");
        ShowCountDown(4);

        int secondsPerCycle = 6;
        int cycles = duration / secondsPerCycle;

        for (int i = 0; i < cycles; i++)
        {
        Console.WriteLine("Breathe in...");
        ShowCountDown(3);
        Console.WriteLine("Breathe out...");
        ShowCountDown(4);
        }   
        
        Console.WriteLine();
        ShowSpinner(2);
        Console.WriteLine("Breathing Activity Completed");
        
        
        DisplayEndidngMessage(duration);
        ShowSpinner(5);
        Console.Clear();
    }


    
}