using System;

class SubstitutionCipher
{
    static void Main()
    {
        string key = "jfkgotmyvhspcandxlrwebquiz";
        string plainText = "Hi Joshclone welcome to Bezao task3 encryption and decryption program";
        string cipherText = Encrypt(plainText, key);
        string decryptedText = Decrypt(cipherText, key);

        Console.WriteLine("Plain     : {0}", plainText);
        Console.WriteLine("Encrypted : {0}", cipherText);
        Console.WriteLine("Decrypted : {0}", plainText);
        Console.ReadKey();
    }

    static string Encrypt(string plainText, string key)
    {
        char[] chars = new char[plainText.Length];

        for (int i = 0; i < plainText.Length; i++)
        {
            if (plainText[i] == ' ')
            {
                chars[i] = ' ';
            }
            else
            {
                int j = plainText[i] - 97;
                chars[i] = key[j];
            }
        }

        return new string(chars);
    }

    static string Decrypt(string cipherText, string key)
    {
        char[] chars = new char[cipherText.Length];

        for (int i = 0; i < cipherText.Length; i++)
        {
            if (cipherText[i] == ' ')
            {
                chars[i] = ' ';
            }
            else
            {
                int j = key.IndexOf(cipherText[i]) - 97;
                chars[i] = (char)j;
            }
        }

        return new string(chars);
    }
}
