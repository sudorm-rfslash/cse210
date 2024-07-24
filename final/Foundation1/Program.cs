using System;
// Some of the videos or comments were copied form real YT videos for this assignment.
class Program
{
  static void Main(string[] args)
  {
    List<Video> videos = new List<Video>();

    Video video1 = new Video("Me at the zoo", "jawed", 19);
    video1.CreateComment("SanDeigoZoo", "We're so honored that the first ever YouTube video was filmed here!");
    video1.CreateComment("ilkoallexandroff", "What? For some reason this was in my recommended now? In 2020? Thanks YouTube!");
    video1.CreateComment("buggus6A", "This being recommend 19 years later is crazy lol");

    Video video2 = new Video("Never Gonna Give You Up (Official Music Video)", "Rick Astley", 212);
    video2.CreateComment("RickAstleyYT", "1 BILLION views for Never Gonna Give You Up!  Amazing, crazy, wonderful! Rick ♥");
    video2.CreateComment("comfyghost", "I looked up this video forgot that I did, clicked the tab and got rick rolled by my past self");
    video2.CreateComment("randomguyontheinternet1005", "wait this is not the link to Shrek X: Endgame");
    
    Video video3 = new Video("The Gummy Bear Song", "icanrockyourworld", 163);
    video3.CreateComment("someguy82", "This song is so catchy!");
    video3.CreateComment("roundspeaker", "I come back to this song to relisten to it at least once a month.");
    video3.CreateComment("refriedfajita", "Where can I buy the album?");
    video3.CreateComment("george", "This song has been stuck in my head for the past hour and I'm really upset about it.");

    videos.Add(video1);
    videos.Add(video2);
    videos.Add(video3);
    Console.WriteLine("--------------------");
    Console.WriteLine($"Video Count: {videos.Count()}");
    Console.WriteLine("--------------------");
    foreach (Video video in videos)
    {
      video.GetVideoInfo();
      Console.WriteLine("--------------------");
    }
  }
}