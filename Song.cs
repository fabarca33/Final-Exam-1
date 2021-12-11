using System;

public class Song 
{
  private string id;

  string Id
  {
    get {return id;}
    set 
    { 
      if (value.Length == 10)
      value = id;

      else
      Console.WriteLine("Invalid ID");
    }
  }

  string Title{get; set;}

  Artist ArtistInfo {get; set;}

  public Song()
  {

  }

  public Song(string ID, string title)
  {
    Id = ID;
    Title = title;
  }

  public void AddArtistInfo(Artist artist) 
  {
    ArtistInfo = artist;


    Console.WriteLine("Artist " +ArtistInfo +" added to the song titled " +Title);

  }

  public void Display()
  {
    Console.WriteLine("Song info: " +Id +". " +Title +" made by " +ArtistInfo);
  }



}