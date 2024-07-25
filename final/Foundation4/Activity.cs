public abstract class Activity
{
  private string _date;
  private int _minutes;

  public Activity(string date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public abstract string GetSummary();

  public virtual double GetDistance()
  {
    return 0.0;
  }

  public virtual double GetSpeed()
  {
    return 0.0;
  }

  public virtual double GetPace()
  {
    return 0.0;
  }

  public string GetDate()
  {
    return _date;
  }

  public int GetMinutes()
  {
    return _minutes;
  }

}