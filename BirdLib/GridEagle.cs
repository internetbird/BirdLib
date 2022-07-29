using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib
{
    public class GridEagle
    {
        public static List<Point> GetAllNeighbourPointsFor(int x, int y, int gridSize)
        {
            var neighbourPoints = new List<Point>();

            if (x > 0)
            {
                neighbourPoints.Add(new Point(x - 1, y));

            } 

            if (x < (gridSize - 1))
            {
                neighbourPoints.Add(new Point(x + 1, y));
            } 

            if (y > 0)
            {
                neighbourPoints.Add(new Point(x, y - 1));
            } 

            if (y < (gridSize - 1))
            {
                neighbourPoints.Add(new Point(x, y + 1));
            }

            return neighbourPoints;
        }
    }
}
