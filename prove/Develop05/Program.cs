using System;
// I created a few more methods to help me make things easier for myself. I made a getpoints method, a printpointtotal method. This way I could fetch a live update of the point total on the fly.
class Program
{
  static void Main(string[] args)
  {
    GoalManager manager = new GoalManager();
    manager.start();
    Console.WriteLine("Thank you for playing!");
  }
}