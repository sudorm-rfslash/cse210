public class Fraction
{
  int _top;
  int _bottom;
  public Fraction()
  {
    // Default to 1/1
    _top = 1;
    _bottom = 1;
  }
  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }
  public int GetTop()
  {
    return _top;
  }
  public void SetTop(int top)
  {
    _top = top;
  }
  public int GetBottom()
  {
    return _bottom;
  }
  public void SetBottom(int bot)
  {
    _bottom = bot;
  }
  public string GetFractionString()
  {
    return ($"{_top}/{_bottom}");
  }
  public double GetDecimalValue()
  {
    return ((double)_top /(double) _bottom);
  }
}