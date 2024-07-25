class Reception : Event
{

  private bool _rsvp;
  private bool _register;
  public Reception(string title, string desc, string date, string time, Address address, bool rsvp, bool register) : base(title, desc, date, time, address)
  {
    _rsvp = rsvp;
    _register = register;
    SetEventType("Reception");
  }

  public string GetRsvp()
  {
    if (_rsvp) return "\nRSVP Required.";
    else return "";
  }

  public string GetRegister()
  {
    if (_register) return "\nRegistration Required.";
    else return "";
  }

  public override string GetFullDetails()
  {
    return base.GetFullDetails() + $"{GetRsvp()}{GetRegister()}";
  }
}