using System.Runtime.InteropServices;

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
    Console.WriteLine("");
    Console.WriteLine(_description);
    Console.WriteLine("");
    ShowSpinner(5);
    Console.Write("How long, in seconds would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine();
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!");
    ShowSpinner(5);
    Console.WriteLine("");
    Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
    ShowSpinner(5);
    Console.Clear();
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
    Console.Write("\b ");
  }
}