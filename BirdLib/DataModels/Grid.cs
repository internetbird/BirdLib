using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.DataModels
{
    public class Grid<T>
    {
        private T[,] _items;

        public int RowSize => _items.GetLength(0);
        public int ColumnSize => _items.GetLength(1);

        public Grid(int rowSize, int columnSize)
        {
            _items = new T[rowSize, columnSize];
        }

        public void SetItem(T item, int rowIndex, int columnIndex)
        {
            _items[rowIndex, columnIndex] = item;
        }

        public T GetItem(int rowIndex, int columnIndex)
        {
            return _items[rowIndex, columnIndex];
        }

        public int GetValueCount(T value)
        {
            int count = 0;

            for (int i = 0; i < RowSize; i++)
            {
                for(int j = 0; j < ColumnSize; j++)
                {
                    if (GetItem(i, j).Equals(value))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public Grid<T> GetSubGridSquare(int rowIndex, int columnIndex, int squareSize)
        {
            var subGrid = new Grid<T>(squareSize, squareSize);
            for (int i = rowIndex; i < rowIndex + squareSize; i++)
            {
                for (int j = columnIndex; j < columnIndex + squareSize; j++)
                {
                    subGrid.SetItem(_items[i, j], i - rowIndex, j - columnIndex);
                }
            }

            return subGrid;
        }

        public void SetSubGrid(int rowIndex, int columnIndex, Grid<T> grid)
        {
            for (int i = 0; i < grid.RowSize; i++)
            {
                for (int j = 0; j < grid.ColumnSize; j++)
                {
                    SetItem(grid.GetItem(i, j), rowIndex + i, columnIndex + j);
                }
            }
        }

        /// <summary>
        /// Checks whether the grids have the same size and items
        /// </summary>
        /// <param name="objectToCompare"></param>
        /// <returns></returns>
        public override bool Equals(object objectToCompare)
        {
            Grid<T> gridToCompare = objectToCompare as Grid<T>;

            if (gridToCompare == null) return false;

            if (gridToCompare.RowSize != RowSize || gridToCompare.ColumnSize != ColumnSize)
            {
                return false;
            }

            for (int i = 0; i < gridToCompare.RowSize; i++)
            {
                for (int j = 0; j < gridToCompare.ColumnSize; j++)
                {
                    if (!gridToCompare.GetItem(i, j).Equals(GetItem(i,j)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Flips the grid columns
        /// </summary>
        /// <returns></returns>
        public Grid<T> FlipVertically()
        {
            var flipptedGrid = new Grid<T>(RowSize, ColumnSize);

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    flipptedGrid.SetItem(GetItem(i, ColumnSize - j - 1), i, j);
                }
            }

            return flipptedGrid;
        }

        /// <summary>
        /// Flips the grid rows
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Grid<T> FlipHorizontally()
        {
            var flipptedGrid = new Grid<T>(RowSize, ColumnSize);

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    flipptedGrid.SetItem(GetItem(RowSize - i - 1,j), i, j);
                }
            }

            return flipptedGrid;
        }

        public Grid<T> RotateRight()
        {
            var rotatedGrid = new Grid<T>(ColumnSize, RowSize);

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    rotatedGrid.SetItem(GetItem(ColumnSize - j - 1, i), i, j);
                }
            }

            return rotatedGrid;
        }

        public Grid<T> RotateLeft()
        {
            var rotatedGrid = new Grid<T>(ColumnSize, RowSize);

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    rotatedGrid.SetItem(GetItem(j, RowSize-i - 1), i, j);
                }
            }

            return rotatedGrid;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var result = string.Empty;

            for (int i = 0; i < RowSize; i++)
            {
                var row = string.Empty;

                for (int j = 0; j < ColumnSize; j++)
                {
                    row += GetItemAsString(i, j);
                }

                result += row + '\n';
               
            }

            return result;
        }

        public int SumValues()
        {
            int sum = 0;

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    sum += GetItemAsInt(i, j);
                }
            }

            return sum;
        }

        private int GetItemAsInt(int i, int j)
        {
            T item = GetItem(i, j);

            if (item is int)
            {
                return Convert.ToInt32(item);

            } else if (item is bool)
            {
                return Convert.ToBoolean(item) ? 1 : 0;
            } else
            {
                return 0;
            }
        }

        private string GetItemAsString(int i, int j)
        {
            T item = GetItem(i, j);

            if (item is bool)
            {
                return Convert.ToBoolean(item) ? "#" : ".";
            } else
            {
                return item.ToString();
            }
        }
    }
}
