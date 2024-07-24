class Event
{
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  private Address _address;

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
    return $"{_title}: {_description} - {_date} {_time} - Address: {_address}";
  }

  public string GetFullDetails()
  {
    return $"{_title}: {_description} - {_date} {_time} - Address: {_address}";
  }

  public string GetShortDescription()
  {
    return $"{_title}: {_description} - {_date} {_time} - Address: {_address}";
  }
}