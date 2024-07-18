public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  public Activity()
  {

  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine(_name);
    Console.WriteLine("Enter how Many seconds: ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine(_description);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Yay you did it!");
  }

  public void ShowSpinner(int seconds)
  {
    List<string> spinner = new List<String> { "|", "/", "-", "\\" };
    int symbol = 0;
    int timer = 0;
    while (timer < seconds)
    {
      Thread.Sleep(1000);
      Console.Write($"\b \b{spinner[symbol]}");
      if (symbol == 3) symbol = 0;
      timer++;
      symbol++;
    }
    Console.Write("\b");
  }

  public void showCountDown(int seconds)
  {
    Thread.Sleep(1000);
    while (seconds > 0)
    {
      Console.Write($"\b \b{seconds}");
      Thread.Sleep(1000);
      if (seconds >= 10) Console.Write("\b \b\b ");
      seconds--;
    }
    Console.Write("\b");
  }
}