using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib
{
    public static class ListCrow
    {
        public static List<int> GenerateIntegerSequence(int start, int end)
        {
            var list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            return list;
        }
    }
}
