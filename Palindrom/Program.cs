using System;
using System.Linq;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo/zdanie: ");
            string text = new string(Console.ReadLine());

            CheckPalindrom(text);

            static void CheckPalindrom(string text)
            {
                text = text.Replace(" ", "").ToLower();

                string zdanie = new string(text.ToCharArray().Reverse().ToArray());

                if (zdanie == text && !String.IsNullOrEmpty(text))
                {
                    Console.WriteLine("To jest palindrom.");
                }
                else if (String.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Nie wpisano żadnego słowa.");
                }
                else
                {
                    Console.WriteLine("To nie jest palindrom.");
                }
            }
        }
    }
}
