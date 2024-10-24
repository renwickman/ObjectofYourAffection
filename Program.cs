using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      Console.WriteLine(sam.ViewProfile());
      sam.setHobbies(new string[] {
        "listening to audiobooks and podcasts", 
        "playing rec sports like bowling and kickball", 
        "reading advice columns"
        });
      Console.WriteLine(sam.ViewProfile());
    }
  }
}