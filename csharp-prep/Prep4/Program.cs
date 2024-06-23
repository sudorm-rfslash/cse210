using System;
using System.Numerics;

class Program
{
  static void Main(string[] args)
  {
    List<int> numbers = new List<int>();
    Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
    int input = 1;
    int sum = 0;
    int count = 0;
    int largest = 0;
    while (input != 0)
    {
      Console.Write("Enter number: ");
      string userinput = Console.ReadLine();
      input = int.Parse(userinput);
      if (input != 0)
      {
        numbers.Add(input);
      }
    }
    foreach (int number in numbers)
    {
      sum += number;
      count++;
      if (number > largest)
      {
        largest = number;
      }
    }
    float average = ((float)sum) / ((float)count);
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largest}");
  }
}