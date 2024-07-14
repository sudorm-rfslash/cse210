using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
  static void Main(string[] args)
  {
    Reference proverbsRef = new Reference("Proverbs", 3, 5, 6);
    Scripture proverbsScrip = new Scripture(proverbsRef, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
    run(proverbsScrip,2);
  }
  public static void run(Scripture script, int hideCount)
  {
    Console.WriteLine(script.GetDisplayText());
    String input = "";
    while (script.IsCompletelyHidden() == false || input.ToLower() == "quit")
    {
      script.HideRandomWords(hideCount);
      Console.Clear();
      Console.WriteLine(script.GetDisplayText());
      input = Console.ReadLine();
    }
  }
}