using System;

class AlwaysOne
{
  static void Main()
  {
      Console.WriteLine("Give me a number!");
      Console.WriteLine("I will magically turn it into 1");
      string strNumber = Console.ReadLine();

      int userNumber = int.Parse(strNumber);
      int numberOne = userNumber / userNumber;

      string strNumberOne = numberOne.ToString();

      Console.WriteLine("aaaaaand what a surprise... you're number is now " + strNumberOne + "!");
  }

}
