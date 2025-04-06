using System.ComponentModel;

public class ListingActivity : Activity
{
    List<string> _prompt = new List<string>();
    public ListingActivity(string name, string description, List<string> prompt) : base(name, description)
    {
        _prompt = prompt;
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
        Console.WriteLine("Take a few moment to think about this prompt : ");
        ShowCountDown(2);
        Console.WriteLine("You will start listing in ");
        ShowCountDown(5);

        Console.WriteLine("\nNow start to list : ");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> UserList = new List<string>();

        while (DateTime.Now < endTime)
        {
            string list = Console.ReadLine();
            if (!string.IsNullOrEmpty(list))
            {
                UserList.Add(list);
            }
        }
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have made {UserList.Count} list ");
        Console.WriteLine();


        DisplayEndidngMessage(duration);
        ShowSpinner(5);
        Console.Clear();

    }
    
     

     

}