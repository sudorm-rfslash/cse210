class Address
{
  private string _street;
  private string _city;
  private string _stateProvince;
  private string _country;

  public bool GetInUsa()
  {
    if (_country.ToLower() == "usa") return true;
    else return false;
  }

  public string GetFullAddress()
  {
    return $"{_street}\n{_city} {_stateProvince}\n{_country}";
  }
}