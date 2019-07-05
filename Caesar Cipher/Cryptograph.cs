using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Caesar_Cipher
{
    /*
     Write a console application that can both encrypt and decrypt messages (Caesar Cipher).

        Limitations:
        -It only needs to work with letters and spaces (no numbers or special characters)
        -Convert all letters to lowercase before encrypting and decrypting
        -All spaces need to be converted to % when encrypting
        -Only positive integers are allowed for keys
     */
    public static class Cryptograph
    {
        public static void Main(string[] args)
        {
            var optionSelected = MenuPrompt();
            switch (optionSelected)
            {
                case 1:
                    //EncryptPrompt
                    Console.Write("Message to Encrypt:");
                    var message = Console.ReadLine().ToLower();
                    Console.Write("Please enter a Key:");
                    var key = int.Parse(Console.ReadLine());
                    //end Prompt
                    var encryptedMessage = Encrypt(message, key);
                    break;
                case 2:
                    DecryptMessage.Decrypt();
                    break;
                default:
                    Console.WriteLine("Thanks for exiting my Program!\n Peace.");
                    break;
            }

            
            Console.WriteLine();
            Console.ReadLine();
        }
        public static int MenuPrompt()
        {
            Console.WriteLine("Select an option: \n 1) Encrypt message \n 2) Decrypt message \n 0) Exit");
            Console.Write("Selected option:");
            var optionSelected = int.Parse(Console.ReadLine());
            return optionSelected;
        }

        public static string Encrypt(string message, int key)
        {
            var abcList = new List<int>();
            var abcCharList = new List<char>();
            var myAbcArray = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var encryptedMessage = new char[message.Length];

            var errorMessage = "ERROR";

            abcCharList.AddRange(myAbcArray);

            if (message.Any(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                var messageWithPercent = message.Replace(' ', '%');

                foreach (var item in messageWithPercent)
                {
                    if (!item.Equals('%'))
                    {
                        var newMessage = myAbcArray.ToList().IndexOf(item) + key;
                        encryptedMessage.Append(myAbcArray[newMessage]);
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                     
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            return encryptedMessage.ToString();
            
        }
    }
}
