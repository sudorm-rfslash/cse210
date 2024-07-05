
using System.Net;

public class Journal
{
  public List<Entry> _entries;
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine($"Date: {entry._date} — Prompt: {entry._promptText}");
      Console.WriteLine(entry._entryText);
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
        outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
    }
  }

  public void LoadFromFile(string file)
  {
    string[] lines = System.IO.File.ReadAllLines(file);
    Entry newEntry = new Entry();
    foreach (string line in lines)
    {
      string[] parts = line.Split("|");

      newEntry._date = parts[0];
      newEntry._promptText = parts[1];
      newEntry._entryText = parts[2];
    }
  }

}