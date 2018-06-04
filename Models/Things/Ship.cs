using System;
using System.Collections.Generic;

namespace PocketUniverse
{
    public class Ship : Thing
    {

            public int HyperSpeed { get; set; }
            public int SpaceSpeed { get; set; }
            public int AirSpeed { get; set; }
            public int SpaceAcceleration { get; set; }
            public int AirAcceleration { get; set; }
            
            
        public Ship()
        {
            

        }
    }
}