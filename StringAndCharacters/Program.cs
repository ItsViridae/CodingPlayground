using System;
using System.Linq;
using System.Text;

namespace StringAndCharacters
{
    class Program
    {
        //strings and Characters. create a method that takes in a string and 2 integers. Switch the two characters at those two indexs.
        static void Main(string[] args)
        {
            var givenString = "My New String";
            int value1 = 0;
            int value2 = 1;

            Console.WriteLine(SwitchCharacters(givenString, value1, value2));
        }

        public static string SwitchCharacters(string givenString, int valueOne, int valueTwo)
        {
            var sb = new StringBuilder(givenString);

            var temp = sb[valueOne];
            sb[valueOne] = sb[valueTwo];
            sb[valueTwo] = temp;

            return sb.ToString();
        }
    }
}
