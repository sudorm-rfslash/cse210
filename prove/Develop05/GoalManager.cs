using System.Runtime.InteropServices;

public class GoalManager
{
  private List<Goal> _goals = new List<Goal>();
  protected int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void start()
  {
    int input = 0;
    while (input != 7)
    {
      Console.WriteLine("Menu Options: ");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Check Points");
      Console.WriteLine("  7. Quit");
      Console.Write("Select a choice from the menu: ");
      input = int.Parse(Console.ReadLine());
      Console.WriteLine();
      if (input == 1)
      {
        CreateGoal();
      }
      else if (input == 2)
      {
        ListGoalDetails();
      }
      else if (input == 3)
      {
        SaveGoals();
      }
      else if (input == 4)
      {
        LoadGoals();
      }
      else if (input == 5)
      {
        RecordEvent();
      }
      else if (input == 6)
      {
        PrintGoalPoints();
      }
    }
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_goals.Count()} Goals.");
    PrintGoalPoints();
  }

  public void ListGoalNames()
  {
    int i = 1;
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetShortName()}");
      i++;
    }
  }

  public void ListGoalDetails()
  {
    int i = 1;
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetDetailString}");
    }
    PrintGoalPoints();
  }

  public void CreateGoal()
  {
    int input = 0;
    Console.WriteLine();
    Console.WriteLine("The types of Goals are: ");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Which type of Goal would you like to create? ");
    input = int.Parse(Console.ReadLine());

    Console.WriteLine();
    if (input == 1)
    {
      Console.Write("What is the name of your goal? ");
      string name = Console.ReadLine();
      Console.Write("What is a short description of it? ");
      string description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal? ");
      string points = Console.ReadLine();
      _goals.Add(new SimpleGoal(name, description, points));
    }
    else if (input == 2)
    {
      Console.Write("What is the name of your goal? ");
      string name = Console.ReadLine();
      Console.Write("What is a short description of it? ");
      string description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal? ");
      string points = Console.ReadLine();
      _goals.Add(new EternalGoal(name, description, points));
    }
    else if (input == 3)
    {
      Console.Write("What is the name of your goal? ");
      string name = Console.ReadLine();
      Console.Write("What is a short description of it? ");
      string description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal? ");
      string points = Console.ReadLine();
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      int target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for completing this goal? ");
      int bonus = int.Parse(Console.ReadLine());
      _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }
  }

  public void RecordEvent()
  {
    Console.WriteLine();
    ListGoalNames();
    Console.Write("Which Goal do you wish to update? ");
    int pick = int.Parse(Console.ReadLine());
    pick--; //this will account for the 0 place in the list
    _goals[pick].RecordEvent();
    Console.WriteLine($"Your Goal \"{_goals[pick].GetShortName()}\" has been updated!");
    Console.WriteLine($"> {_goals[pick].GetDetailString()}");
    Console.WriteLine();
  }

  public void SaveGoals()
  {
    Console.Write("What is the filename of the goal file? ");
    string filename = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename of the goal file? ");
    string filename = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(filename);
    _goals.Clear(); // Clear the existing entries if any
    foreach (string line in lines)
    {
      string[] parts = line.Split('|');
      if (parts[0] == "simple")
      {
        SimpleGoal simple = new SimpleGoal(parts[1], parts[2], parts[3]);
        _goals.Add(simple);
        if (bool.Parse(parts[4])) simple.RecordEvent();
      }
      else if (parts[0] == "eternal")
      {
        _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
      }
      else if (parts[0] == "checklist")
      {
        ChecklistGoal check = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
        _goals.Add(check);
        int completions = int.Parse(parts[6]);
        int i = 0;
        while (i < completions) check.RecordEvent();
      }
    }
  }

  public int GetTotalPoints()
  {
    int total = 0;
    foreach (Goal goal in _goals)
    {
      total = total + goal.GetPoints();
    }
    return total;
  }
  public void PrintGoalPoints()
  {
    Console.WriteLine("");
    Console.WriteLine($"You have {GetTotalPoints()} points.");
    Console.WriteLine("");
  }

}