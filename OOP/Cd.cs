using System;
using System.Collections.Generic;

class Cd
{
    public string Title;
    public string Artist;
    public int Price;
}

public class Program
{
    public static void Main()
    {
        Cd first = new Cd();
        first.Title = "Master of Reality";
        first.Artist = "Black Sabbath:";
        first.Price = 10;

        Cd second = new Cd();
        second.Title = "Electric Ladyland";
        second.Artist = "Jimi Hendrix";
        second.Price = 10;

        Cd third = new Cd();
        third.Title = "Nevermind";
        third.Artist = "Nirvana";
        third.Price = 10;

        List<Cd> Cds= new List<Cd>() {first, second, third};

        foreach (Cd album in Cds)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine("By " + album.Artist);
            Console.WriteLine("Price $" + album.Price);
        }
    }
}
