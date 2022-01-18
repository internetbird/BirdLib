using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdLib
{
    /// <summary>
    /// A helper class for creating permutaions
    /// </summary>
    public class PermutationGenerator
    {
        public List<T[]> GetAllPermutations<T>(T[] input)
        {
            var permutations = new List<T[]>();

            if (input.Length == 1)
            {
                return new List<T[]> { input };
            }

            for (int i = 0; i < input.Length; i++)
            {
                var currItem = input[i];
                var listWithoutCurrItem = new List<T>(input);
                listWithoutCurrItem.Remove(currItem);

                List<T[]> subArrayPermutations = GetAllPermutations(listWithoutCurrItem.ToArray());

                foreach (T[] item in subArrayPermutations)
                {
                    T[] fullPermutationArray = item.PrependItem(input[i]);
                    permutations.Add(fullPermutationArray);
                }
            }

            return permutations;
        }

        public List<string[]> GetAllCircularPermutations(string[] input)
        {
            if (input.Length < 2)
            {
                return new List<string[]> { input };
            }

            var firstItem = input[0];

            var arrayWithoutFirstItem = input.SubArray(1, input.Length - 1);

            List<string[]> permutationsWithoutFirstItem = GetAllPermutations(arrayWithoutFirstItem);

            return permutationsWithoutFirstItem
                .Select(permutation => permutation.PrependItem(firstItem))
                .ToList();
        }

        public List<Tuple<T, T>> GetAllCouples<T>(List<T> items)
        {
            var result = new List<Tuple<T,T>>();

            for (int i = 0; i < items.Count; i++)
            {
                T firstItem = items[i];
           
                for (int j = i + 1; j < items.Count; j++)
                {
                    T secondItem = items[j];
                    Tuple<T,T> couple = new Tuple<T, T>(firstItem, secondItem);

                    result.Add(couple);
                }
            }

            return result;
        }
    }
}
