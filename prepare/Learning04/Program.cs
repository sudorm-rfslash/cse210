using System;

class Program
{
  static void Main(string[] args)
  {
    Assignment assign = new Assignment("Samuel Bennett","Multiplication");
    Console.WriteLine(assign.GetSummary());
    Console.WriteLine();

    MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
    Console.WriteLine(math.GetSummary());
    Console.WriteLine(math.GetHomeworkList());
    Console.WriteLine();

    WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(writing.GetSummary());
    Console.WriteLine(writing.GetWritingInformation());
    Console.WriteLine();

    Assignment blank = new Assignment();
    Console.WriteLine(blank.GetSummary());

  }
}