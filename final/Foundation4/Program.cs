using System;

class Program
{
  static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>();
    Running running = new Running("11 November 2024", 60, 7.1);
    Cycling cycling = new Cycling("24 July 2024", 30, 18.2);
    Swimming swimming = new Swimming("01 August 2024", 20, 25);

    activities.Add(running);
    activities.Add(cycling);
    activities.Add(swimming);

    Console.WriteLine("Events: ");
    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.GetSummary());
      Console.WriteLine("");
    }

  }
}