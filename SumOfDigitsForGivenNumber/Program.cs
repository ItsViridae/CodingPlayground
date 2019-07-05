using System;
using System.Threading;

namespace SumOfDigitsForGivenNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var done = 0;
            Console.WriteLine("Enter a number for me to add:");

            var userInput1 = Console.ReadLine();
            var parsed = int.Parse(userInput1);

            while (Calculates(parsed.ToString()).ToString().Length > 1)
            {
               //done = int.Parse(Calculates(parsed.ToString()).ToString());
            }
            Console.WriteLine($"{done}");
            Console.ReadLine();
        }

        public static int Calculates(string number)
        {
            var res = 0;
            foreach (var item in number)
            {
                res += int.Parse(item.ToString());
            }
            return res;
        }
    }
}
