using System;
using System.Collections.Generic;

namespace PocketUniverse
{
    public class Vehicle : Thing
    {
        public int CargoCapacity { get; set; }
        public List<Thing> CargoItems { get; set; }
        public List<ShipComponent> ShipComponents { get; set; }
    }
}