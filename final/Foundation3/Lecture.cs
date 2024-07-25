using System.Diagnostics;

class Lecture : Event
{
  private string _speaker;
  private int _capacity;
  public Lecture(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
  {
    _speaker = speaker;
    _capacity = capacity;
    SetEventType("Lecture");
  }

  public override string GetFullDetails()
  {
    return base.GetFullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
  }
}