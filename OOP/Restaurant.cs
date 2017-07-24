using System;
using System.Collections.Generic;

class Restaurant
{
    public string name;
    public bool vegan;
    public bool peanutFree;
    public bool organic;

    public Restaurant(string rName, bool rVegan = false, bool rPeanut = false, bool rOrganic = false)
    {
        name = rName;
        vegan = rVegan;
        peanutFree = rPeanut;
        organic = rOrganic;
    }
}

class Program
{
    public static void Main()
    {
        Restaurant rest1 = new Restaurant("Panda Inn", true, false, false);
        Restaurant rest2 = new Restaurant("Russel St BBQ");
        Restaurant rest3 = new Restaurant("Uno Mas", true, true, false);
        Restaurant rest4 = new Restaurant("Katie O'brian's", false, true, true);

        List<Restaurant> Restaurants = new List<Restaurant>() {rest1, rest2, rest3, rest4};

        foreach (Restaurant location in Restaurants)
        {
            Console.WriteLine(location.name);
            Console.WriteLine("\t vegan: " + location.vegan);
            Console.WriteLine("\t peanut-free: " + location.peanutFree);
            Console.WriteLine("\t organic: " + location.organic);
        }
    }
}
