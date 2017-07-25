using System;

class CdTry
{
    private int _price;
    // Setter Method
    public void SetPrice(int newPrice)
    {
        if (newPrice >= 0)
        {
            _price = newPrice;
        }
        else
        {
            Console.WriteLine("The price for this item is not valid");
        }
    }

    public int GetPrice()
    {
        return _price;
    }

    public static void Main()
    {
        CdTry tester = new CdTry();
        Console.WriteLine(tester.GetPrice());
        tester.SetPrice(10);
        Console.WriteLine(tester.GetPrice());
    }
}
