using System;
using System.Collections.Generic;
using System.Text;

namespace BirdLib
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Retruns a subarray
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }

        /// <summary>
        /// Appends an item to the end of the array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="itemToAppend"></param>
        /// <returns></returns>
        public static T[] AppendItem<T>(this T[] array, T itemToAppend)
        {
            T[] result = new T[array.Length + 1];

            Array.Copy(array, 0, result, 0, array.Length);
            result[array.Length] = itemToAppend;

            return result;
        }

        /// <summary>
        /// Adds an item to the head of the array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="itemToPrepend"></param>
        /// <returns></returns>
        public static T[] PrependItem<T>(this T[] array, T itemToPrepend)
        {
            T[] result = new T[array.Length + 1];
            result[0] = itemToPrepend;
            Array.Copy(array, 0, result, 1, array.Length);

            return result;

        }
    }
}
