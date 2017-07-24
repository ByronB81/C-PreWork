using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("What year were you born in?");
        string strBirthYear = Console.ReadLine();
        int birthYear = int.Parse(strBirthYear);

        Console.WriteLine("You were alive for these leap years:");
        for (int year = birthYear; year <= 2017; year++)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine(year);
            }
        }
    }
}
