using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdLib
{
    public static class StringExtensions
    {

        /// <summary>
        /// Returns the char frequency dictionary for the given word
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Dictionary<char, int> GetCharFrequencyDictionary(this string input)
        {
            var result = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!result.ContainsKey(letter))
                {
                    result.Add(letter, 1);
                } else
                {
                    result[letter]++;
                }
            }

            return result;

        }

        /// <summary>
        /// Repeats the given string N times
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Repeat(this string s, int n)
           => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();


        /// <summary>
        /// Swaps the characters at the given indexes
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        public static string SwapIndexes(this string input, int index1, int index2)
        {
            char[] charArray = input.ToCharArray();

            char index1Char = charArray[index1];
            char index2Char = charArray[index2];

            charArray[index1] = index2Char;
            charArray[index2] = index1Char;

            return new string(charArray);
        }


        /// <summary>
        /// Shifts the string right
        /// </summary>
        /// <param name="input"></param>
        /// <param name="numOfPositions"></param>
        /// <returns></returns>
        public static string ShiftRight(this string input, int numOfPositions)
        {

            int shiftAmount = numOfPositions % input.Length;

            string firstPart = input.Substring(input.Length - shiftAmount);
            string secondPart = input.Substring(0, input.Length - shiftAmount);
            return firstPart + secondPart;
        }

        /// <summary>
        /// Shifts the string left
        /// </summary>
        /// <param name="input"></param>
        /// <param name="numOfPositions"></param>
        /// <returns></returns>
        public static string ShiftLeft(this string input, int numOfPositions)
        {
            int shiftAmount = numOfPositions % input.Length;

            string firstPart = input.Substring(shiftAmount, input.Length - shiftAmount);
            string secondPart = input.Substring(0, shiftAmount);
            return firstPart + secondPart;
        }

        /// <summary>
        /// Reverses part of the string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public static string ReversePart(this string input, int startIndex, int endIndex)
        {
            string reversedPart = input.Substring(startIndex, endIndex - startIndex + 1);

            reversedPart = new string(reversedPart.ToCharArray().Reverse().ToArray());

            string prefix = input.Substring(0, startIndex);
            string suffix = string.Empty;

            if (endIndex < input.Length - 1)
            {
                suffix = input.Substring(endIndex + 1);
            }

            return $"{prefix}{reversedPart}{suffix}";
        }

        /// <summary>
        /// Changes the index of a character in a string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="fromIndex"></param>
        /// <param name="toIndex"></param>
        /// <returns></returns>
        public static string ChangeIndex(this string input, int fromIndex, int toIndex)
        {
            char[] charArray = input.ToCharArray();
            char charToMove = charArray[fromIndex];

            string result = input.Remove(fromIndex, 1);
            result = result.Insert(toIndex, charToMove.ToString());

            return result;
        }

        /// <summary>
        /// Returns true if the string contains strait three letters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool HasStraightThreeLetters(this string input)
        {
            for (int i = 0; i < input.Length - 2; i++)
            {
                if ((input[i + 1] == input[i] + 1) && (input[i + 2] == input[i + 1] + 1))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks for two difference letter pairs
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ContainsTwoDifferentLetterPairs(this string input)
        {
            bool firstPairFound = false;
            char firstPairChar = default(char);
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    if (!firstPairFound)
                    {
                        firstPairFound = true;
                        firstPairChar = input[i];
                    }
                    else
                    {
                        if (input[i] != firstPairChar)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Removes the first and last chars of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveFirstAndLastChars(this string input)
        {
            if (input.Length < 2)
            {
                return input;
            }

            return input.Substring(1, input.Length - 2);
        }


        public static string RemovePart(this string input, int startIndex, int length)
        {
            string firstSection = input.Substring(0, startIndex);
            string secondSection = input.Substring(startIndex + length);
            return string.Concat(firstSection, secondSection);
             
        }
    }

  
}
