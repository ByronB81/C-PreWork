using System;

class Heroes
{
    static void Main()
    {
        string[] heroList = {"Captain America", "Batman", "Ironman", "Superman"};

        Console.WriteLine("COOL HEROES:");
        for (int index = 0; index < heroList.Length; index++)
        {
            Console.WriteLine(heroList[index]);
        }
    }
}
