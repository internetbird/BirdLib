using BirdLib.DataModels;
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

        public static int GetItemsCountWithValue<T>(Grid<T> grid, T value)
        {
            int count = 0;
            for (int i = 0; i < grid.RowSize; i++)
            {
                for (int j = 0; j < grid.ColumnSize; j++)
                {
                    if (grid.GetItem(i, j).Equals(value))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int GetManhattenDistance(GridPoint point1, GridPoint point2)
        {
            return Math.Abs(point1.RowIndex - point2.RowIndex) + Math.Abs(point1.ColumnIndex- point2.ColumnIndex);  
        }
    }
            
}
