using System.ComponentModel.DataAnnotations;

class Video
{
  string _title;
  string _author;
  int _length;
  List<Comment> _comments = new List<Comment>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  public void CreateComment(string author, string text)
  {
    _comments.Add(new Comment(author, text));
  }

  public int GetCommentCount()
  {
    return _comments.Count();
  }

  public void GetVideoInfo()
  {
    int minutes = _length / 60;
    int seconds = _length % 60;
    Console.WriteLine($"{_title} -- By: {_author} -- {minutes}:{seconds} ({_length} Seconds)");
    Console.WriteLine($"Comment Count: {GetCommentCount()}");
    foreach (Comment comment in _comments)
    {
      Console.WriteLine(comment.GetCommentInfo());
    }
  }

}