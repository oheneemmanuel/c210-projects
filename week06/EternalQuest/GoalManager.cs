using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddPoints(int points)
    {
        _score += points;
        Console.WriteLine($"You have earned points! Your total score is now {_score} points.");
    }
    
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal ");
            Console.WriteLine("3. save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            
            

        }
       
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are : ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter the points for the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for points.");
            return;
        }
        
        if (goalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            Console.WriteLine(simpleGoal.GetDetails());
        }
        else if (goalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            Console.WriteLine($"Eternal Goal '{name}' created successfully!");
        }
        else if (goalType == "3")
        {
            Console.Write("Enter the target for the checklist goal: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for target.");
                target = -1; // Default value
            }
            
            
            Console.Write("Enter the bonus for completing the checklist goal: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for bonus.");
                bonus = 0; // Default value
            }
           
            
            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(checkListGoal);
            Console.WriteLine($"CheckList Goal '{name}' created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }
        Console.WriteLine("Goal created successfully!");

    }
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        Console.WriteLine("Goals: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetStringRepresentation()}");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to save.");
            return;
        }
        try 
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error while saving: " + ex.Message);
        }
        

  
    }
    public void LoadGoals()
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        try
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }

            

            _score = int.Parse(lines[0]);
            Console.WriteLine($"Score loaded: {_score}");
            // Load goals from the file

            for (int i = 1; i < lines.Length; i++)
            {
                
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                
                    string[] parts = lines[i].Split(':');

                    string type = parts[0];
                    string[] data = parts[1].Split(',');

                    switch (type)
                    {
                        case "SimpleGoal":

                            var sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                            sg.SetComplete(bool.Parse(data[3]));
                            _goals.Add(sg);
                            break;



                        case "EternalGoal":

                            var eg = new EternalGoal(data[0], data[1], int.Parse(data[2]));

                            _goals.Add(eg);
                            break;


                        case "CheckListGoal":

                            var clg = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));


                            clg.SetAmountCompleted(int.Parse(data[3]));
                            _goals.Add(clg);
                            break;


                        default:
                            Console.WriteLine($"Unknown goal type: {type}");
                            break;
                    }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error while loading: " + ex.Message);
        }
    }


   
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events.");
            return;
        }
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");

        }
        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice <= 1 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            Console.WriteLine($"Event recorded for goal: {selectedGoal.GetDetails()}");
            
          
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }


    }
}
