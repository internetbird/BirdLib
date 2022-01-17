using System;
using System.Collections.Generic;
using System.Text;

namespace BirdLib
{
    public class MatrixOwl
    {
        public int[,] ParseIntMatrix(string[] lines)
        {
            int numOfColumns = lines[0].Length;
            int numOfRows = lines.Length;

            int[,] map = new int[numOfRows, numOfColumns];

            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    map[i, j] = int.Parse(lines[i][j].ToString());
                }
            }

            return map;
        }
    }
}
