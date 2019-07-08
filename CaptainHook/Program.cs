using System;
using System.Net.NetworkInformation;

namespace CaptainHook
{
    /*
     * Captain Hook and his crew are currently resting at Origin Shore. They are about to embark on their next adventure to an undisclosed location (x, y) to find treasure.
       
       Captain Hook's ship can only move exactly north, south, east or west. It takes exactly 1 day for the ship to travel 1 unit in one of the four cardinal directions.
       
       After every 5 days, the crew will take one day of rest.
       
       Given the location of the treasure, find out how long it takes for Captain Hook and his crew to find the treasure. The ship is currently at coordinate (0, 0).
     */
    class Program
    {
        static void Main(string[] args)
        {
            var originX = 0;
            var originY = 0;

            Console.WriteLine("Captain Hook and his crew are embarking their next adventure. \n Give Coordinates of their Next journey:");
            Console.WriteLine("( _ , _ ) \n X value: ");
            var xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Y value: ");
            var yCoordinate = int.Parse(Console.ReadLine());

            if (xCoordinate > 0)
            {
                Console.WriteLine($"Cap went East: {xCoordinate} Units");
            }
            else
                Console.WriteLine($"Cap went West: {xCoordinate * -1} Units");

            if (yCoordinate > 0)
            {
                Console.WriteLine($"Cap went North: {yCoordinate} Units");
            }
            else
                Console.WriteLine($"Cap went South: {yCoordinate * -1} Units");

            var numberOfDays = xCoordinate + yCoordinate;

            //every 5 days add 1 Day.
            numberOfDays += numberOfDays % 5;
            

            Console.WriteLine("Hello World!");
        }
    }
}
