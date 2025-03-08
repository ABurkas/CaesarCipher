using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Program
    {
        static void inputData(out int key, out string text, out string choice)
        {
            Console.Write("Enter your text: ");
            text = Console.ReadLine();
            Console.Write("Encrypt/Decrypt: ");
            choice = Console.ReadLine();

            bool validKey = false;
            key = 0;
            while (!validKey)
            {
                Console.Write("Enter the key: ");
                validKey = int.TryParse(Console.ReadLine(), out key);
                if (!validKey) Console.WriteLine("Invalid key! Enter a number.");

            }
        }
        static string modeChoice(string choice, string text, int key)
        {
            bool looping = true;
            while (looping)
            {
                choice = choice.ToLower();
                if (choice != "encrypt" && choice != "decrypt")
                {
                    Console.WriteLine("Invalid mode!");
                    return null;
                }
                else
                {
                    looping = false;
                    if (choice == "encrypt")
                    {
                        return encrypt(text, key);
                    }
                    else
                    {
                        return decrypt(text, key);
                    }
                }
            }
            return null;
        }
        static string encrypt(string text, int key)
        {
            char[] shiftedChars = new char[text.Length];

            for (int i = 0; i < shiftedChars.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]) || char.IsPunctuation(text[i]))
                {
                    shiftedChars[i] = text[i];
                }
                else if (char.IsUpper(text[i]))
                {
                    shiftedChars[i] = (char)((text[i] - 'A' + key) % 26 + 'A');
                }
                else if (char.IsLower(text[i]))
                {
                    shiftedChars[i] = (char)((text[i] - 'a' + key) % 26 + 'a');
                }
                else
                {
                    shiftedChars[i] = text[i];
                }
            }
            return new string(shiftedChars);
        }
        static string decrypt(string text, int key)
        {
            char[] shiftedChars = new char[text.Length];
            for (int i = 0; i < shiftedChars.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]) || char.IsPunctuation(text[i]))
                {
                    shiftedChars[i] = text[i];
                }
                else if (char.IsUpper(text[i]))
                {
                    shiftedChars[i] = (char)((text[i] - 'A' - key) % 26 + 'A');
                }
                else if (char.IsLower(text[i]))
                {
                    shiftedChars[i] = (char)((text[i] - 'a' - key) % 26 + 'a');
                }
                else
                {
                    shiftedChars[i] = text[i];
                }
            }
            return new string(shiftedChars);
        }
        static void Main(string[] args)
        {
            int key = 0;
            string text = string.Empty;
            string choice = text;

            inputData(out key, out text, out choice);
            Console.Write(modeChoice(choice, text, key));
            Console.ReadLine();
        }
    }
}
