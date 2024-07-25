using System;

class Program
{
  static void Main(string[] args)
  {
    Running running = new Running("11 November 2024", 60, 7.1);
    Cycling cycling = new Cycling("24 July 2024", 30, 18.2);
    Swimming swimming = new Swimming("01 August 2024", 20, 25);

    Console.WriteLine("Events: ");
    Console.WriteLine(running.GetSummary());
    Console.WriteLine();
    Console.WriteLine(cycling.GetSummary());
    Console.WriteLine();
    Console.WriteLine(swimming.GetSummary());

  }
}