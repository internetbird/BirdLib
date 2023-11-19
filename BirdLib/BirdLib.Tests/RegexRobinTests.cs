using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BirdLib.Tests
{
    [TestClass]
    public class RegexRobinTests
    {
        [TestMethod]
        public void MatchingConsecutiveCharsTest1()
        {
            MatchCollection matchCollection = RegexRobin.FindMatchingConsecutiveCharacters("12347844");
            Assert.IsTrue(matchCollection.Count == 1);
        }

        [TestMethod]
        public void HasExactlyTwoMatchingConsecutiveCharactersTest1()
        {
           bool result = RegexRobin.HasExactlyTwoMatchingConsecutiveCharacters("123478444");
           Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasExactlyTwoMatchingConsecutiveCharactersTest2()
        {
            bool result = RegexRobin.HasExactlyTwoMatchingConsecutiveCharacters("12347844");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasExactlyTwoMatchingConsecutiveCharactersTest3()
        {
            bool result = RegexRobin.HasExactlyTwoMatchingConsecutiveCharacters("177778");
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void HasExactlyTwoMatchingConsecutiveCharactersTest4()
        {
            bool result = RegexRobin.HasExactlyTwoMatchingConsecutiveCharacters("1233478");
            Assert.IsTrue(result);
        }


    }
}
