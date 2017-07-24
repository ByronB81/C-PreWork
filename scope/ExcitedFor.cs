using System;

class ExcitedFor
{
    static void Main()
    {
        string[] excitedForList = {"epicodus", "family", "vacation"};
        int total = 0;

        foreach (string thing in excitedForList)
        {
            Console.WriteLine("I am excited for " + thing.ToUpper() + "!!!");
            total++;
        }

        Console.WriteLine("That is " + total + " exciting things!");
    }
}
