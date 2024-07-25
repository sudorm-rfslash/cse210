using System;

class Program
{
  static void Main(string[] args)
  {
    Address lectureAddress = new Address("1234 Lecture Way", "Denver", "Colorado", "USA");
    Address receptionAddress = new Address("9876 Reception Road", "Salt Lake City", "Utah", "USA");
    Address outdoorGatheringAddress = new Address("2468 Large Tree Park", "Vancouver", "B.C.", "Canada");

    Lecture lecture = new Lecture("Java Class Lecture", "Join us to learn about the basics of Java!", "September 21st", "6:00 AM", lectureAddress, "John Bytheway", 200);
    Reception reception = new Reception("Redacted's Wedding", "Wedding for Anonymous and Unknown.", "October 2nd", "8:00 PM", receptionAddress, true, true);
    OutdoorGathering outdoorGathering = new OutdoorGathering("Redacted's Wedding", "Wedding for Anonymous and Unknown.", "October 2nd", "8:00 PM", outdoorGatheringAddress, "72° Slightly Cloudy");

    Console.WriteLine("---Lecture---"); //this is to keep the output clean
    Console.WriteLine(lecture.GetStandardDetails());
    Console.WriteLine(lecture.GetFullDetails());
    Console.WriteLine(lecture.GetShortDescription());
    Console.WriteLine();
    Console.WriteLine("---Reception---"); //this is to keep the output clean
    Console.WriteLine(reception.GetStandardDetails());
    Console.WriteLine(reception.GetFullDetails());
    Console.WriteLine(reception.GetShortDescription());
    Console.WriteLine();
    Console.WriteLine("---Outdoor Gathering---"); //this is to keep the output clean
    Console.WriteLine(outdoorGathering.GetStandardDetails());
    Console.WriteLine(outdoorGathering.GetFullDetails());
    Console.WriteLine(outdoorGathering.GetShortDescription());

  }
}