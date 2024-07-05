using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    Entry newEntry = new Entry();
    PromptGenerator generator = new PromptGenerator();
    Journal myJournal = new Journal();
    PromptGenerator gen = new PromptGenerator();
    gen._prompts.Add("Who was the most interesting person I interacted with today?");
    gen._prompts.Add("What was the best part of my day?");
    gen._prompts.Add("How did I see the hand of the Lord in my life today?");
    gen._prompts.Add("What was the strongest emotion I felt today?");
    gen._prompts.Add("If I had one thing I could do over today, what would it be?");
    string userInput = "0";
    int input = 0;
    while (input != 5)
    {
      Console.WriteLine("Please select one of the following choices: ");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      Console.Write("What would you like to do? ");
      userInput = Console.ReadLine();
      input = int.Parse(userInput);
      if (input == 1)
      {
        newEntry._promptText = generator.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._date = "test";
        myJournal.AddEntry(newEntry);
      }
      else if (input == 2)
      {
        myJournal.DisplayAll();
      }
      else if (input == 3)
      {
        Console.WriteLine("What is the file to read from? ");
        string file = Console.ReadLine();
        myJournal.LoadFromFile(file);
      }
      else if (input == 4)
      {
        Console.WriteLine("What is the file to save to? ");
        string file = Console.ReadLine();
        myJournal.SaveToFile(file);
      }
      else if (input == 5)
      {
        return;
      }


    }
  }
}