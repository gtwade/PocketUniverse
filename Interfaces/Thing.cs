using System;
using LiteDB;
using System.Collections.Generic;

namespace PocketUniverse
{
    public class Thing : IThing
    {
        public bool IsAnimate { get; set; }
        public bool IsMoveable { get; set; }
        public int MaxHitPoints { get; set; }
        public int HitPoints { get; set; }
        public int ArmorPoints { get; set; }
        public double MassKg { get; set; }
        public Guid Id { get; set; }
        public Dictionary<string, string> Descriptors;
        public int Scale { get; set; }

        public List<Word> Words { get; set; }

        #region Interface Methods
        public int ReduceHP(int i)
        {
            return HitPoints = 1;
        }

        public int RestoreHP(int i)
        {
            return HitPoints + i;
        }

        public bool IsDestroyed()
        {
            if (HitPoints > 0)
            {
                return true;
            }

            return false;
        }

        public double WeightForGravity(double mass, double gravity)
        {
            // is this the right calculation? 
            // https://www.grc.nasa.gov/www/k-12/airplane/wteq.html
            // real equation = mass * g (gravitational acceleration)
            return mass * gravity;
        }
        #endregion
    }
}