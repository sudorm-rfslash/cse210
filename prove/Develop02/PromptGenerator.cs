
public class PromptGenerator()
{
  public List<string> _prompts = new List<string>();

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int promptNum = random.Next(01, _prompts.Count) - 1;
    return _prompts[promptNum];
  }
}