using System;
using LiteDB;

namespace PocketUniverse
{
    public interface IThing
    {
        int ReduceHP(int i);
        int RestoreHP(int i);
        bool IsDestroyed();
        double WeightForGravity(double mass, double gravity);
    }
}