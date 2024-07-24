public class SimpleGoal : Goal
{
  bool _iscomplete = false;
  public SimpleGoal(string name, string description, string points) : base(name, description, points)
  {

  }

  public override void RecordEvent()
  {

  }

  public override bool IsComplete()
  {
    return _iscomplete;
  }

  public override string GetStringRepresentation()
  {
    return $"simple|{_shortName}|{_description}|{_points}";
  }
}