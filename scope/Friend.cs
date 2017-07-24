using System;

class Friend
{
    static void Main()
    {
        string[] friendList = {"Sarah", "Susan", "Scott", "Matt", "Danimal"};
        int friendTotal = 0;
        Console.WriteLine("These are my friends!");

        foreach (string friend in friendList)
        {
            Console.WriteLine(friend + " is my friend, definitely!");
            friendTotal++;
        }

        Console.WriteLine("That's " + friendTotal + " whole friends!");
    }
}
