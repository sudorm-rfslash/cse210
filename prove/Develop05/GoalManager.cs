using System.Runtime.InteropServices;

public class GoalManager
{
  List<Goal> _goals = new List<Goal>();
  int _score;

  public GoalManager()
  {

  }

  public void start()
  {
    int input = 0;
    while (input != 6)
    {
      Console.WriteLine("Menu Options: ");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Quit");
      Console.Write("Select a choice from the menu: ");
      input = int.Parse(Console.ReadLine());
      Console.Clear();
      if (input == 1)
      {
        CreateGoal();
      }
      else if (input == 2)
      {
        ListGoalNames();
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

    }
  }

  public void DisplayPlayerInfo()
  {

  }

  public void ListGoalNames()
  {

  }

  public void ListGoalDetails()
  {
    int i = 1;
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetDetailString}");
    }
    Console.WriteLine();
    Console.WriteLine($"You have {_score} points.");
    Console.WriteLine();
  }

  public void CreateGoal()
  {
    int input = 0;
    Console.WriteLine("The types of Goals are: ");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Which type of Goal would you like to create? ");
    input = int.Parse(Console.ReadLine());

    Console.Clear();
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
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      int bonus = int.Parse(Console.ReadLine());
      _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }
  }

  public void RecordEvent()
  {

  }

  public void SaveGoals()
  {

  }

  public void LoadGoals()
  {

  }

}