using System;
using System.Collections.Generic;

class Cd
{
    public string Title;
    public string Artist;
    public int Price;

    public Cd(string albumTitle, string albumArtist, int albumPrice = 10)
    {
        Title = albumTitle;
        Artist = albumArtist;
        Price = albumPrice;
    }
}

public class Program
{
    public static void Main()
    {
        Cd first = new Cd("Master of Reality", "Black Sabbath");
        Cd second = new Cd("Electric Ladyland", "Jimi Hendrix");
        Cd third = new Cd("Nevermind", "Nirvana");
        Cd fourth = new Cd("I Don't Get It", "Pork Lion", 50);

        List<Cd> Cds= new List<Cd>() {first, second, third, fourth};

        foreach (Cd album in Cds)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine("By " + album.Artist);
            Console.WriteLine("Price $" + album.Price);
        }
    }
}
