using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsAPalidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a String to check if it is a palindrome or not:");
            var word = Console.ReadLine();

            Console.WriteLine(IsPalidrome(word));
        }

        public static bool IsPalidrome(string word)
        {
            var reversedWord = new string(word.Reverse().ToArray());
            return reversedWord == word;
        }
    }
}
