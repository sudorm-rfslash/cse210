using System;
using System.IO;
// above and beyond: you can type the number or the word to choose an option. EX: 1 or write, 2 or display... ETC
class Program
{
  static void Main(string[] args)
  {
    Journal myJournal = new Journal();
    PromptGenerator prompts = new PromptGenerator();
    prompts._prompts.Add("Who was the most interesting person I interacted with today?");
    prompts._prompts.Add("What was the best part of my day?");
    prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
    prompts._prompts.Add("What was the strongest emotion I felt today?");
    prompts._prompts.Add("If I had one thing I could do over today, what would it be?");
    string userInput = "0";
    while (userInput != "5" || userInput.ToLower() != "quit")
    {
      Console.WriteLine("Please select one of the following choices: ");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      Console.Write("What would you like to do? ");
      userInput = Console.ReadLine();
      if (userInput == "1" || userInput.ToLower() == "write")
      {
        Entry newEntry = new Entry();
        newEntry._promptText = prompts.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        Console.Write("> ");
        string enter = Console.ReadLine();
        Console.WriteLine(enter);
        newEntry._entryText = enter;
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        myJournal.AddEntry(newEntry);
      }
      else if (userInput == "2" || userInput.ToLower() == "display")
      {
        myJournal.DisplayAll();
      }
      else if (userInput == "3" || userInput.ToLower() == "load")
      {
        Console.WriteLine("What is the file to read from? ");
        string file = Console.ReadLine();
        myJournal.LoadFromFile(file);
      }
      else if (userInput == "4" || userInput.ToLower() == "save")
      {
        Console.WriteLine("What is the file to save to? ");
        string file = Console.ReadLine();
        myJournal.SaveToFile(file);
      }
      else if (userInput == "5" || userInput.ToLower() == "quit")
      {
        return;
      }
      Console.WriteLine("");
    }
  }
}