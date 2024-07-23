public class SimpleGoal : Goal
{
  bool _iscomplete = false;
  public SimpleGoal(string name, string description, string points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public void RecordEvent()
  {

  }

  public bool IsComplete()
  {
    return _iscomplete;
  }

  public string GetStringRepresentation()
  {

  }
}