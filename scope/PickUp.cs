using System;

class PickUp
{
    static void Main()
    {
        string[] groceryList = {"eggs", "bread", "milk", "fruit", "salsa", "bacon"};
        int[] priceList = {3, 2, 4, 5, 4, 6};

        Console.WriteLine("My grocery List");

        foreach (string item in groceryList)
        {
            Console.WriteLine(item);
        }

        int total = 0;
        foreach (int price  in priceList)
        {
            total = total + price;
        }

        Console.WriteLine("Your total will be $" + total);
    }
}
