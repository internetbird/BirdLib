using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib
{
    /// <summary>
    /// Some useful utility methods that work with lists
    /// </summary>
    public static class ListCrow
    {
        /// <summary>
        /// Generates integers sequence within a range
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<int> GenerateIntegerSequence(int start, int end)
        {
            var list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            return list;
        }

        /// <summary>
        /// Returns true if the given integer array is sorted in non-decreasing order
        /// </summary>
        /// <param name="series"></param>
        /// <returns></returns>
        public static bool IsNonDecreasingSeries(int[] series)
        {
            for (int i = 0; i < series.Length - 1; i++)
            {
                if (series[i+1] < series[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
