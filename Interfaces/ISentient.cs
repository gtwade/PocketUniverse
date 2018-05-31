using System;

namespace PocketUniverse
{
    public interface ISentient
    {
        void Say (string sentence);
        void Eat (string food);
        void FeelEmotion(string emotion);
    }
}