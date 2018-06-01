using System;
using LiteDB;

namespace PocketUniverse
{
    public class Map : IMap
    {
        Guid Id { get; set; }
        public ScaleType Scale { get; set; }
        public int Dimension { get; set; }
        public Map[,] MapArray { get; set; }
        public bool CanTakeMapPoints { get; set; }

        #region Ctor
        public Map() {}

        public Map(ScaleType scale, int dimension, bool canTakeMapPoints)
        {
            Scale = scale;
            Dimension = dimension;
            CanTakeMapPoints = canTakeMapPoints;

            InitializeMapArray(dimension);
        }
        #endregion

        public void InitializeMapArray(int dimension)
        {
            MapArray = new Map[dimension, dimension];
        }

        public void AddMapPoint(int x, int y, Map map, ScaleType scale, int dimension, bool canTakeMapPoints)
        {
            if (MapArray[x, y] == null)
            {
                MapArray[x, y] = new Map(scale, dimension, canTakeMapPoints);
            }
        }
    }
}