using System;
using System.Collections.Generic;

class Car
{
    public string MakeModel;
    public int Price;
    public int Miles;
}

public class Program
{
    public static void Main()
    {
        Car porsche = new Car();
        porsche.MakeModel = "2014 Porsche 911";
        porsche.Price = 114991;
        porsche.Miles = 7864;

        Car ford = new Car();
        ford.MakeModel = "2011 Ford F250";
        ford.Price = 55995;
        ford.Miles = 14241;

        Car mercedes = new Car();
        mercedes.MakeModel = "Mercedes benz CL550";
        mercedes.Price = 39900;
        mercedes.Miles = 37979;

        List<Car> CarList = new List<Car>() {porsche, ford, mercedes};
        foreach (Car ride in CarList)
        {
            Console.WriteLine(ride.MakeModel);
        }

        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        List<Car> CarsMatchingSearch = new List<Car>();

        foreach (Car ride in CarList)
        {
            if (ride.Price < maxPrice)
            {
                CarsMatchingSearch.Add(ride);
            }
        }

        foreach (Car ride in CarsMatchingSearch)
        {
            Console.WriteLine(ride.MakeModel);
        }
    }
}
