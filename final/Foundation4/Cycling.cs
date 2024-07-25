public class Cycling : Activity
{
  private double _speed;

  public Cycling(string date, int minutes, double speed) : base(date, minutes)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    return (_speed * GetMinutes()) / 60;
  }

  public override double GetSpeed()
  {
    return _speed;
  }

  public override double GetPace()
  {
    return 60 / _speed;
  }

  public override string GetSummary()
  {
    return $"{GetDate()} Cycling ({GetMinutes()} min)- Speed {GetSpeed():F1} mph, Distance {GetDistance():F1} miles, Pace: {GetPace():F1} min per mile";
  }
}