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
            var isExited = false;
            while (!isExited)
            {
                var optionSelected = MenuPrompt();

                switch (optionSelected)
                {
                    case 0:
                        Console.WriteLine("Thanks for exiting my Program!\n Peace.");
                        isExited = true;
                        break;
                    case 1:
                        //EncryptPrompt
                        Console.Write("Message to Encrypt:");
                        var message = Console.ReadLine().ToLower();
                        Console.Write("Please enter a Key:");
                        var key = int.Parse(Console.ReadLine());
                        //end Prompt
                        var encryptedMessage = Encrypt(message, key);
                        Console.WriteLine(encryptedMessage);
                        break;
                    case 2:
                        //DecryptPrompt
                        Console.Write("Message to Decrypt:");
                        var messageToDecrypt = Console.ReadLine().ToLower();
                        Console.Write("Please enter the Key:");
                        var decryptKey = int.Parse(Console.ReadLine());
                        //end Prompt
                        var decryptedMessage = Decrypt(messageToDecrypt, decryptKey);
                        Console.WriteLine(decryptedMessage);
                        break;
                    default:
                        Console.WriteLine("Not sure what you want...");
                        break;
                }
            }
           
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
            var myAbcArray = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var encryptedMessage = string.Empty;

            var errorMessage = "ERROR";

            key = key % myAbcArray.Length;

            if (message.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                var messageWithPercent = message.Replace(' ', '%');

                foreach (var item in messageWithPercent)
                {
                    var newCharacter = item;
                    if (char.IsLetter(item))
                    {
                        var indexOfItem = myAbcArray.ToList().IndexOf(item);
                        var proposedIndex = indexOfItem + key;
                        if(proposedIndex >= myAbcArray.Count())
                        {
                            proposedIndex = key - (myAbcArray.Count() - indexOfItem);
                        }

                        newCharacter = myAbcArray[proposedIndex];
                    }

                    encryptedMessage += newCharacter;
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            return encryptedMessage;
        }

        public static string Decrypt(string message, int key)
        {
            var myAbcArray = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var decryptedMessage = string.Empty;
            var errorMessage = "ERROR";

            key = key % myAbcArray.Length;

            var messageWithSpace = message.Replace('%', ' ');
            

            if (messageWithSpace.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                
                foreach (var item in messageWithSpace)
                {
                    var newCharacter = item;
                    if (char.IsLetter(item))
                    {
                        var indexofItem = myAbcArray.ToList().IndexOf(item);
                        var proposedIndex = indexofItem - key;
                        if (proposedIndex < 0)
                        {
                            proposedIndex = proposedIndex * -1;
                        }


                        newCharacter = myAbcArray[proposedIndex];
                    }
                    decryptedMessage += newCharacter;
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            return decryptedMessage;
        }
    }
}
