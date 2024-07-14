public class Reference
{
  string _book;
  int _chapter;
  int _verse;
  int _endVerse;

  public Reference(String book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = 0;
  }

  public Reference(String book, int chapter, int startVerse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _verse = startVerse;
    _endVerse = endVerse;
  }
  public string GetDisplayText()
  {
    if (_endVerse == 0) return _book + " " + _chapter + ":" + _verse;
    else return _book + " " + _chapter + ":" + _verse+"-"+_endVerse;
  }
}