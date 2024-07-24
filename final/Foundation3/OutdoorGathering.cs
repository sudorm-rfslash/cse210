class OutdoorGathering : Event
{
  private string _forecast;
  public OutdoorGathering(string title, string desc, string date, string time, Address address, string forecast) : base(title, desc, date, time, address)
  {
    _forecast = forecast;
  }
}