public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, string points)
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
    return false;
  }

  public string GetStringRepresentation()
  {

  }
}