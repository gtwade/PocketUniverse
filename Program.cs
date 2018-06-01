using System;
using LiteDB;

// uses LiteDB library for storing data.

namespace PocketUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameStart gameStart = new GameStart();
            //gameStart.Start();
            var galaxy = new Galaxy(ScaleType.Galaxy, 19, true);

            Console.WriteLine(galaxy.MapArray.Length.ToString());

        }
    }
}
