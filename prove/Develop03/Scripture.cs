using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Scripture
{
  Reference _reference;
  List<Word> _words = new List<Word> { };

  public Scripture(Reference reference, String text)
  {
    _reference = reference;
    string[] words = text.Split(' ');
    foreach (String word in words)
    {
      Word temp = new Word(word);
      _words.Add(temp);


    }

  }
  public void HideRandomWords(int numberToHide)
  {
    int count = 0;
    Random rand = new Random();

    while (count < numberToHide)
    {
      int randWord = rand.Next(0, _words.Count);

      if (!_words[randWord].IsHidden())
      {
        _words[randWord].Hide();
        count++;
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