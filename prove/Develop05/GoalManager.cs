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
        listing.Run();
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

    }

    public void CreateGoal()
    {

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