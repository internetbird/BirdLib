using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdLib
{
    public static class MathExtensions
    {
        public static ulong Sum(this List<ulong> list)
        {
            return list.Aggregate((ulong)0, (accomulator, current) => accomulator + current);
        }

        public static ulong Multiply(this List<ulong> list)
        {
            return list.Aggregate((ulong)1, (accomulator, current) => accomulator * current);
        }

        public static bool IsPrime(this int value)
        {
            if (value <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
