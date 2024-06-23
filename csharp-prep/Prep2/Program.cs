using System;

class Program
{
  static void Main(string[] args)
  {
    char letter = ' ';
    Console.Write("What is your grade percentage? ");
    string input = Console.ReadLine();
    int grade_percent = int.Parse(input);
    if (grade_percent >= 90){
      letter = 'A';
    }
    else if (grade_percent >= 80){
      letter = 'B';
    }
    else if (grade_percent >= 70){
      letter = 'C';
    }
    else if (grade_percent >= 60){
      letter = 'D';
    }
    else{
      letter = 'F';
    }
    Console.WriteLine($"Your grade is: {letter}");
    if(grade_percent >= 70){
      Console.WriteLine("You pass!");
    }
    else{
      Console.Write("You need at least 70% to pass, Try better next time!");
    }
  }
}