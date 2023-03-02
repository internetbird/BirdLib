using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.DataModels
{
    public class GridPoint
    {
        public GridPoint(){}

        public GridPoint(int rowIndex, int columnIndex)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
        }

        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }
}
