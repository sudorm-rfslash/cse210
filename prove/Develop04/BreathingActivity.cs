public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public void Run()
  {
    DisplayStartingMessage();
    Console.Write("How many seconds per interval? ");
    int interval = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int mod = _duration % interval;
    int count = _duration / interval;
    while (count >= 1)
    {
      Console.Write("Breathe in:  ");
      showCountDown(interval);
      Console.WriteLine("");
      Console.Write("Breathe Out:  ");
      showCountDown(interval);
      Console.WriteLine("");
      count--;
    }
    if (mod > 0) ShowSpinner(mod);
  }
}