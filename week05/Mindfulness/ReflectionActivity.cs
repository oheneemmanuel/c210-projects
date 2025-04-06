public class ReflectionActivity : Activity

{

    List<string> _prompt = new List<string>();
    List<string> _questions = new List<string>();
    public ReflectionActivity(string name, string description, List<string> prompt, List<string> questions) : base(name, description)
    {
        _prompt = prompt;
        _questions = questions;

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

        Random random = new Random();
        string selectedPrompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine("Consider the following  prompt :");
        Console.WriteLine($"------{selectedPrompt}-------");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue,");
        Console.ReadLine();
        ShowSpinner(2);
        Console.WriteLine("\nNow ponder on each of the questions as they are related to this experience");
        Console.WriteLine($"You may begin in :");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string selectedQuestion = _questions[random.Next(_questions.Count)];
            
            Console.WriteLine($"----{selectedQuestion}---");
            ShowSpinner(5);
        }
        Console.WriteLine();
        DisplayEndidngMessage(duration);
        Console.WriteLine("About to quit");
        ShowSpinner(4);
        Console.Clear();
        
        
    }
}

              

