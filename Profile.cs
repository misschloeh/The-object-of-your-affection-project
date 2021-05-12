using System;

namespace DatingProfile
{ 
  class Profile
   {
     //fields
     private string name;
     private int age;
     private string city;
     private string country;
     private string pronouns;
     private string[] hobbies;
     
     //constructors
     public Profile(string name, int age, string city, string country, string pronouns = "they/them") {
       this.name = name;
       this.age = age;
       this.city = city;
       this.country = country;
       this.pronouns = pronouns;
       this.hobbies = new string[] {};
     }
      //methods
      public string ViewProfile() {
        string currentHobbies = " ";
        foreach(string hobbie in hobbies) {
          currentHobbies += hobbie + ", ";
        };
        string bio = $"Name: {name},\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: {currentHobbies}";
        return bio;
      }
      
      public void SetHobbies(string[] hobbies){
        this.hobbies = hobbies;
      }

     
  }
}
