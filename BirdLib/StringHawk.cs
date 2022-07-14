using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdLib
{
    /// <summary>
    /// This class contains useful string operation methods
    /// </summary>
    public class StringHawk
    {
        public int GetNumOfDifferentChars(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                throw new ArgumentException("str1 and str2 must have the same length");
            }

            int numOfDifferenceChars = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    numOfDifferenceChars++;
                }
            }

            return numOfDifferenceChars;
        }

        public string GetCommonLetters(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                throw new ArgumentException("str1 and str2 must have the same length");
            }

            var commonLettersStr = string.Empty;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[i])
                {
                    commonLettersStr += str1[i];
                }
            }

            return commonLettersStr;
        }


        public static string ConvertHexStringToBinaryString(string hexString)
        {
            string binarystring = string.Join(string.Empty,
                      hexString.Select(
                        c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                      )
                );

            return binarystring;
        }

    }
}
