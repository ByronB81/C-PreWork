using System;

class Cryptor
{
    static void Main()
    {
        Console.WriteLine("Please enter a text you would like to encrypt");
        string userInput = Console.ReadLine();
        string aEncrypt = userInput.Replace("a", "4");
        string eEncrypt = aEncrypt.Replace("e","3");
        string iEncrypt = eEncrypt.Replace("i", "1");
        string oEncrypt = iEncrypt.Replace("o", "0");

        string encryptedResult = oEncrypt.Replace("u", "V");
        Console.WriteLine(encryptedResult);
    }
}
