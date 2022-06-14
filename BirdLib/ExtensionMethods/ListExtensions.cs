using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.ExtensionMethods
{
    public static class ListExtensions
    {
        public static List<T> ReversePart<T>(this List<T> list, int startIndex, int length)
        {
            var result = new List<T>(list);

            int listLength = list.Count;

            for (int i = startIndex; i < startIndex+length; i++)
            {

                int originIndex = (2*startIndex + length - 1 - i) % listLength;
                int destinationIndex = i % listLength;
                result[destinationIndex] = list[originIndex];
            }

            return result;
        }
    }
}
