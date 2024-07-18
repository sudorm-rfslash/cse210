using System;

class Program
{
  static void Main(string[] args)
  {
    int input = 0;

    while (input != 4)
    {
      Console.WriteLine("Menu Options: ");
      Console.WriteLine("  1. Start breathing activity");
      Console.WriteLine("  2. Start reflecting activity");
      Console.WriteLine("  3. Start listing activity");
      Console.WriteLine("  4. Quit");
      input = int.Parse(Console.ReadLine());

      BreathingActivity breathe = new BreathingActivity();
      ReflectingActivity reflect = new ReflectingActivity();
      ListingActivity listing = new ListingActivity();

      if (input == 1)
      {
        breathe.Run();
      }
      else if (input == 2)
      {
        Console.Clear();
        reflect.Run();
      }
      else if (input == 3)
      {
        Console.Clear();
        listing.Run();
      }
    }
  }
}