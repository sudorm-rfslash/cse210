using System.Runtime;

public class ChecklistGoal : Goal
{
  int _amountCompleted;
  int _target;
  int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus)
  {
    _shortName = name;
    _description = description;
    _points = points;
    _target = target;
    _bonus = bonus;
  }

  public void RecordEvent()
  {

  }

  public bool IsComplete()
  {
    if (int.Parse(_points) >= _target) return true;
    else return false;
  }

  public string GetDetailString()
  {

  }

  public string GetStringRepresentation()
  {

  }
}