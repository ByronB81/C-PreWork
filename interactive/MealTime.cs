using System;

class MealTime
{
    static void Main()
    {
        AskWhatYouAte("breakfast");
        AskWhatYouAte("lunch");
        AskWhatYouAte("dinner");
    }

    static void AskWhatYouAte(string meal)
    {
        Console.WriteLine("What did you eat for " + meal + "?");
        string yourMeal = Console.ReadLine();
        Console.WriteLine("You had " + yourMeal + " for " + meal + ".");
    }
}
