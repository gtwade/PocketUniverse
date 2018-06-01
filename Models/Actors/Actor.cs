using System;

namespace PocketUniverse
{
    public class Actor : Sentient
    {
        public GenderType Gender { get; set; }
        public string Race { get; set; }
        public Actor()
        {
            Id = new Guid();
        }
    }
}