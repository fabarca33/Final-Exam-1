using System;

class Program {
  public static void Main (string[] args) {
    
    Artist a1 = new Artist("Rick", "Sanchez");

    a1.Display();

    Song s1 = new Song ("1000000001", "Get Schwifty");

    s1.AddArtistInfo(a1);
    s1.Display();

    Song s2 = new Song ("1000000002", "Goodbye Moonman");

    s2.AddArtistInfo(a1);
    s2.Display();

    Song s3 = new Song ("1000000003", "Rick & Morty Theme Song");
    s3.AddArtistInfo(a1);
    s3.Display();





  }


}