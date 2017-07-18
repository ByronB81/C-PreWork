using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it!");
    string strNumber = Console.ReadLine();

    int intNumber = int.Parse(strNumber);
    int doubledNumber = intNumber * 2;

    string outputNumber = doubledNumber.ToString();

    Console.WriteLine("I doubled your number and came up with " + outputNumber + "!");
  }
}
