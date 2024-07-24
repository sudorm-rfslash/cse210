public class EternalGoal : Goal
{
  private int _completions = 0;
  public EternalGoal(string name, string description, string points) : base(name, description, points)
  {

  }

  public override void RecordEvent()
  {
    _completions = _completions + int.Parse(_points);
  }

  public override bool IsComplete()
  {
    return false;
  }

  public override string GetStringRepresentation()
  {
    return $"eternal|{_shortName}|{_description}|{_points}";
  }

  public override int GetPoints()
  {
    if (IsComplete()) return int.Parse(_points);
    else return 0;
  }
}