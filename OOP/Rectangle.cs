using System;

class Rectangle
{
    public int Length;
    public int Width;

    public bool IsSquare()
    {
        if (Length == Width)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Rectangle myRec = new Rectangle();
        Console.WriteLine("Enter the length: ");
        string strLength = Console.ReadLine();
        int intLength = int.Parse(strLength);
        myRec.Length = intLength;

        Console.WriteLine("Enter the width");
        string strWidth = Console.ReadLine();
        int intWidth = int.Parse(strWidth);
        myRec.Width = intWidth;

        if (myRec.IsSquare())
        {
            Console.WriteLine("Yup, it's a square.");
        }
        else
        {
            Console.WriteLine("Nay sir, 'tis but a rectangle.");
        }
    }
}
