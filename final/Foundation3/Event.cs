using System.Diagnostics;

class Event
{
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  private Address _address;
  private string _eventType = "";

  public Event(string title, string desc, string date, string time, Address address)
  {
    _title = title;
    _description = desc;
    _date = date;
    _time = time;
    _address = address;
  }

  public string GetStandardDetails()
  {
    return $"\nStandard Description:\nWhat: {_title}: {_description}\nWhen: {_date} {_time}\nWhere: {_address.GetFullAddress()}";
  }

  public virtual string GetFullDetails()
  {
    return $"\nDetailed Description:\n{_eventType}: {_title}: {_description}\nWhen: {_date} {_time}\nWhere: {_address.GetFullAddress()}";
  }

  public string GetShortDescription()
  {
    return $"\nShort Description:\n{_eventType}\n{_title} @ {_date} {_time}";
  }

  public void SetEventType(string eventType)
  {
    _eventType = eventType;
  }
}