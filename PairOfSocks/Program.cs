using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PairOfSocks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test1 = "AA";
            var test2 = "ABAABC";
            var test3 = "CABBACCC";

            Console.WriteLine($"{test1} found {TestSockPairs(test1)}");
            Console.WriteLine($"{test2} found {TestSockPairs(test2)}");
            Console.WriteLine($"{test3} found {TestSockPairs(test3)}");
        }

        public static int TestSockPairs(string testValues)
        {
            Dictionary<char, int> socksDictionary = new Dictionary<char, int>();

            foreach (var sock in testValues)
            {
                if (socksDictionary.ContainsKey(sock))
                {
                    socksDictionary[sock]++;
                }
                else
                {
                    socksDictionary.Add(sock, 1);
                }
            }

            var numberOfSocks = 0;

            foreach (var sockKey in socksDictionary)
            {
                numberOfSocks += sockKey.Value/2;
            }

            return numberOfSocks;
        } 
    }
}
