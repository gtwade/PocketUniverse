using System;
using System.Linq;
using System.Collections.Generic;

namespace PocketUniverse
{
    public class Character : Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Dictionary<string, string> Descriptors;

        public Database CharacterDb = new Database("character");



    }

}