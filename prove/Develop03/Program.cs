using System;
using System.Security.Cryptography.X509Certificates;
// for my extra challenge the program picks a random scripture and a random number of words between 1-3 to remove.
class Program
{
  static void Main(string[] args)
  {
    Reference proverbsRef = new Reference("Proverbs", 3, 5, 6);
    Scripture proverbsScrip = new Scripture(proverbsRef, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

    Reference johnRef = new Reference("John", 3, 16);
    Scripture johnScrip = new Scripture(johnRef, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

    List<Scripture> scriptures = new List<Scripture> {proverbsScrip,johnScrip};
    Random rand = new Random();
    int whichScripture = rand.Next(1,scriptures.Count());
    run(scriptures[whichScripture],rand.Next(1,3));
  }
  public static void run(Scripture script, int hideCount)
  {
    Console.Clear();
    Console.WriteLine(script.GetDisplayText());
    String input = Console.ReadLine();
    while (script.IsCompletelyHidden() == false && input.ToLower() != "quit")
    {
      script.HideRandomWords(hideCount);
      Console.Clear();
      Console.WriteLine(script.GetDisplayText());
      input = Console.ReadLine();
    }
    Console.Clear();
    Console.WriteLine(script.GetDisplayText());
  }
}