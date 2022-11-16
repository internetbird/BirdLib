﻿using System;
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
   
     }
}
