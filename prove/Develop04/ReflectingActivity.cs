using System.Runtime.InteropServices;

public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();

  public ReflectingActivity(List<string> prompts, List<string> questions)
  {
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _prompts = prompts;
    _questions = questions;
  }

  public ReflectingActivity()
  {
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    _questions = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"]
;
  }

  public void Run()
  {

  }

  public string GetRandomPrompt()
  {
    Random rand = new Random();
    int pick = rand.Next(_prompts.Count());
    return _prompts[pick];
  }

  public string GetRandomQuestion()
  {
    Random rand = new Random();
    int pick = rand.Next(_questions.Count());
    return _questions[pick];
  }

  public void DisplayPrompt()
  {
    Console.WriteLine(GetRandomPrompt());
  }

  public void DisplayQuestions()
  {
    Console.WriteLine(GetRandomQuestion());
  }

}