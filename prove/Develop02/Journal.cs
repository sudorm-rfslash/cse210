
using System.Net;
using System.IO;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
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
    string filename = file;
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    string filename = file;
    string[] lines = System.IO.File.ReadAllLines(filename);
    _entries.Clear(); // Clear the existing entries if any
    foreach (string line in lines)
    {
      string[] parts = line.Split('|');
      Entry newEntry = new Entry
      {
        _date = parts[0],
        _promptText = parts[1],
        _entryText = parts[2]
      };
      _entries.Add(newEntry);
    }
  }

}