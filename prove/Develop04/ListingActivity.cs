public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>();

  public ListingActivity(List<string> prompts)
  {
    _prompts = prompts;
  }

  public ListingActivity()
  {
    _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
  }

  public void Run()
  {
    DisplayStartingMessage();
    DateTime _startTime = DateTime.Now;
    _count = _duration;
    DateTime _futureTime = _startTime.AddSeconds(_count);
    DateTime _currentTime = DateTime.Now;

    GetRandomPrompt();
    List<string> inputs = GetListFromUser(_currentTime,_futureTime);


  }

  public void GetRandomPrompt()
  {
    Random rand = new Random();
    int pick = rand.Next(_prompts.Count());
    Console.WriteLine(_prompts[pick]);
  }

  public List<string> GetListFromUser(DateTime currentTime, DateTime futureTime)
  {
    List<string> inputs = new List<string>();
    while (currentTime < futureTime)
    {
      Console.Write("> ");
      inputs.Add(Console.ReadLine());
    }
    return inputs;
  }
}