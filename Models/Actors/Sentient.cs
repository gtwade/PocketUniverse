using System;

namespace PocketUniverse
{
    public abstract class Sentient : Thing, ISentient
    {
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Willpower { get; set; }

        public void Say(string sentence)
        {

        }

        public void Eat(string food)
        {

        }

        public void FeelEmotion(string emotion)
        {

        }
    }
}