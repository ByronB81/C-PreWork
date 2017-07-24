using System;

class EvenOdd
{
    static void Main()
    {
        Console.WriteLine("Pick a number");
        string strNum = Console.ReadLine();
        int userNumber = int.Parse(strNum);

        for (int i = 0; i <= userNumber; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is even.");
            }
            else
            {
                Console.WriteLine(i + " is odd.");
            }
        }
    }
}
