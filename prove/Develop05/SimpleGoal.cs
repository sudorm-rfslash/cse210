public class SimpleGoal : Goal
{
  private bool _isComplete = false;
  public SimpleGoal(string name, string description, string points) : base(name, description, points)
  {
    _isComplete = false;
  }

  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"simple|{_shortName}|{_description}|{_points}{IsComplete()}";
  }

  public override int GetPoints()
  {
    if (IsComplete()) return int.Parse(_points);
    else return 0;
  }
}