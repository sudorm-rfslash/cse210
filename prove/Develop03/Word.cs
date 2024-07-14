public class Word
{
  string _text;
  bool _isHidden;

  public Word(string word)
  {
    _text = word;
    _isHidden = false;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    if (IsHidden() == true)
    {
      string val = "";
      foreach (char letter in _text)
      {
        val = $"{val}_";
      }
      return val;
    }
    else return _text;
  }
}