using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        Console.WriteLine();

        // Create a list to store activities
        List<Activity> activities = new List<Activity>();

        // Sample data for testing
        activities.Add(new Running(new DateTime(2023, 10, 1), 30, 5.0));
        activities.Add(new Cycling(new DateTime(2023, 10, 2), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2023, 10, 3), 87, 54.7));

        // Display summaries of all activities
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
   
    }
}