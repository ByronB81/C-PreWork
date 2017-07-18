using System;

class Cryptor
{
    static void Main()
    {
        var string phraseHolder;

        Encrypt();
        Decrypt(phraseHolder);
    }

    static void Encrypt()
    {
        Console.WriteLine("Please enter a text you would like to encrypt");
        string userInput = Console.ReadLine();
        string aEncrypt = userInput.Replace("a", "4");
        string eEncrypt = aEncrypt.Replace("e","3");
        string iEncrypt = eEncrypt.Replace("i", "1");
        string oEncrypt = iEncrypt.Replace("o", "0");

        string encryptedResult = oEncrypt.Replace("u", "^");
        var phraseHolder = encryptedResult;
        Console.WriteLine(encryptedResult);
    }

    static void Decrypt(string codedPhrase)
    {
        string aDecrypt = codedPhrase.Replace("4","a");
        string eDecrypt = aDecrypt.Replace("3", "e");
        string iDecrypt = eDecrypt.Replace("1", "i");
        string oDecrypt = iDecrypt.Replace("0", "o");

        string decryptedResult = oDecrypt.Replace("^", "v");
        Console.WriteLine(decryptedResult);

    }
}
