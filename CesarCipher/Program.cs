using System;
using System.Collections.Generic;

namespace CesarCipher
{
    class Program
    {
        public static char[] AlphabetArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static void Main(string[] args)
        {
            string s = Encryption(3, "Smíchov");
            Console.WriteLine(s);
            Console.WriteLine(Decryption(3, s));
            Console.ReadLine();
        }

        static string Encryption(int key, string s)
        {
            string encryptedString = "";
            List<char> charList = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                charList.Add(s.ToLower()[i]);
            }

            for (int i = 0; i < charList.Count; i++)
            {
                int j = 0;
                foreach (var item in AlphabetArray)
                {
                    if (charList[i] == item)
                    {
                        int ch = j + key;
                        if (ch >= AlphabetArray.Length)
                        {
                            ch = ch - AlphabetArray.Length;
                        }
                        encryptedString += AlphabetArray[ch];
                    }
                    j++;
                }
            }
            return encryptedString;
        }

        static string Decryption(int key, string s)
        {
            string decryptedString = "";
            List<char> charList = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                charList.Add(s.ToLower()[i]);
            }

            for (int i = 0; i < charList.Count; i++)
            {
                int j = 0;
                foreach (var item in AlphabetArray)
                {
                    if (charList[i] == item)
                    {
                        int ch = j - key;
                        if (ch < 0)
                        {
                            ch = ch + AlphabetArray.Length;
                        }
                        decryptedString += AlphabetArray[ch];
                    }
                    j++;
                }
            }
            return decryptedString;
        }
    }
}
