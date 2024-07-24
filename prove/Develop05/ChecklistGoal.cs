using System.Runtime;
using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = 0;
  }

  public override void RecordEvent()
  {

  }

  public override bool IsComplete()
  {
    if (int.Parse(_points) >= _target) return true;
    else return false;
  }

  public override string GetDetailString()
  {
    string box = "";
    if (IsComplete()) box = "[X]";
    else box = "[ ]";
    return $"{box} {_shortName} ({_description})";
  }

  public override string GetStringRepresentation()
  {
    return $"checklist|{_shortName}|{_description}|{_points}|{_target}|{_bonus}";
  }
}