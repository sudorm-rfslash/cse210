using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Scripture
{
  Reference _reference;
  List<Word> _words;

  public Scripture(Reference Reference, String text)
  {
    _reference = Reference;
    string[] words = text.Split(' ');
    foreach (String word in words)
    {
      _words[0] = new Word(word);
    }

  }

  public void HideRandomWords(int numberToHide)
  {
    int length = _words.Count();
    Random rand = new Random();
    int count = 0;
    bool completed = false;
    while (count < numberToHide)
    {
      if (IsCompletelyHidden() == false) return;
      completed = false;
      while (completed == false)
      {
        int randWord = rand.Next(0, length);
        if (_words[randWord].IsHidden() == false)
        {
          _words[randWord].Hide();
          completed = true;
          count++;
        }
      }
    }
  }

  public string GetDisplayText()
  {
    string whatToReturn = _reference.GetDisplayText();
    foreach (Word word in _words)
    {
      whatToReturn = $"{whatToReturn} " + word.GetDisplayText() + " ";
    }
    return whatToReturn;
  }

  public bool IsCompletelyHidden()
  {
    bool completelyHidden = true;
    foreach (Word word in _words)
    {
      if (word.IsHidden() == false) completelyHidden = false;
    }
    return completelyHidden;
  }
}