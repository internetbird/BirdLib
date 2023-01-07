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
    }
}
