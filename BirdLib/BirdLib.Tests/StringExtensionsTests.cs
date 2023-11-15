using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void HasStraightNLettersTest1()
        {
            Assert.AreEqual("1435557".HasStraightNLetters(3), true);
        }

        [TestMethod]
        public void HasStraightNLettersTest2()
        {
            Assert.AreEqual("143557".HasStraightNLetters(3), false);
        }


        [TestMethod]
        public void HasStraightNLettersTest3()
        {
            Assert.AreEqual("ABCDE".HasStraightNLetters(1), true);
        }

        [TestMethod]
        public void HasStraightNLettersTest4()
        {
            Assert.AreEqual("1111".HasStraightNLetters(5), false);
        }
    }
}
