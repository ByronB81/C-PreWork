using System;

class Adder
{
    static void Main()
    {
        Console.WriteLine("Give me a number");
        string strNum1 = Console.ReadLine();
        int intNum1 = int.Parse(strNum1);
        Console.WriteLine("Now give me a number to add that to");
        string strNum2 = Console.ReadLine();
        int intNum2 = int.Parse(strNum2);

        int intResult = intNum1 + intNum2;
        string strResult = intResult.ToString();

        Console.WriteLine("The sum of " + strNum1 + " and " + strNum2 + " equals " + strResult);
    }
}
