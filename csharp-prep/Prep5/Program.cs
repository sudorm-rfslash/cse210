using System;
using System.Globalization;

class Program
{
  static void Main(string[] args)
  {
    DisplayWelcome();
    string username = PromptUserName();
    int number = PromptUserNumber();
    int squared = SquareNumber(number);
    DisplayResult(username,squared);
  }
  static void DisplayWelcome()
  {
    Console.WriteLine("Welcome to the Program!");
  }
  static string PromptUserName()
  {
    Console.Write("Please enter your name: ");
    return Console.ReadLine();
  }
  static int PromptUserNumber()
  {
    Console.Write("Please enter your favorite number: ");
    return int.Parse(Console.ReadLine());
  }
  static int SquareNumber(int num)
  {
    return num*num;
  }
  static void DisplayResult(string name, int square)
  {
    Console.WriteLine($"{name}, the square of your number is {square}");
  }
}