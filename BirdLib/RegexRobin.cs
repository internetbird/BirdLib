using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BirdLib
{
    public class RegexRobin
    {
        public static MatchCollection FindMatchingConsecutiveCharacters(string input)
        {
            return Regex.Matches(input, @"([a-zA-Z0-9])\1");
        }

        public static bool HasExactlyTwoMatchingConsecutiveCharacters(string input)
        {
           MatchCollection matchCollection = FindMatchingConsecutiveCharacters(input);

            if (!matchCollection.Any()) return false;

            foreach (Match match in matchCollection)
            {
                if ((match.Index == input.Length - 2 || input[match.Index] != input[match.Index + 2]) &&
                    (match.Index < 2 || input[match.Index] != input[match.Index -2]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
