using System;
using LiteDB;

// uses LiteDB library for storing data.

namespace PocketUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart gameStart = new GameStart();
            gameStart.Start();
        }
    }
}
