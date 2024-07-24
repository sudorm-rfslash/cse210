using System.ComponentModel;

public abstract class Goal
{
  protected string _shortName;
  protected string _description;
  protected string _points;

  public Goal(string name, string description, string points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public abstract void RecordEvent();
  public abstract bool IsComplete();
  public abstract string GetStringRepresentation();
  public abstract int GetPoints();

  public virtual string GetDetailString()
  {
    string box = "";
    if (IsComplete()) box = "[X]";
    else box = "[ ]";
    return $"{box} {_shortName} ({_description})";
  }

  public string GetShortName()
  {
    return _shortName;
  }


}