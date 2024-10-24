using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

  public Profile(
    string name, 
    int age, 
    string city, 
    string country, 
    string pronouns="they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }
    public string ViewProfile()
    {
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";

      bio += "\nHobbies:";
      foreach (string hobby in hobbies){
        bio += $" - {hobby}";

      }
      
      return age < 18 ? "You are not of age to make a profile" : bio;
    }
    public void setHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
