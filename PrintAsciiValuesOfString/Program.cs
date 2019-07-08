using System;
using System.Collections.Generic;

namespace PrintAsciiValuesOfString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var myListOfAscii = new List<int>();

            Console.WriteLine("input a string to be Converted into Ascii:");
            var givenString = Console.ReadLine();

            foreach (var item in givenString)
            {
                Console.WriteLine($"{ item } { (int)item }");
            }
        }
    }
}
