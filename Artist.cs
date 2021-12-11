using System;

public class Artist
{
 string FirstName {get; set;}
 string LastName {get; set;}
 string Email {get; set;}

 public Artist (string fname, string lname)
 {
   FirstName = fname;
   LastName = lname;
   Email = "Unknown";
 }

 public void Display()
 {
   Console.WriteLine("Artist info: " +FirstName +" " +LastName);
 }
}
