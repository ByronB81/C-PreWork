using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Pick a number");
        string strNum = Console.ReadLine();
        int yourNumber = int.Parse(strNum);
        pingPong(yourNumber);
    }

    static void pingPong(int pingNumber)
    {
        for (int i = 1; i <= pingNumber; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("PING PONG");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Pong");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Ping");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
