using BirdLib.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirdLib.Tests
{
    [TestClass]
    public class ListExtensionsTests
    {

        [TestMethod]
        public void ReversePartTest1()
        {
            var list = new List<int> { 0, 1, 2, 3, 4 };

            var result = list.ReversePart(0, 3);

            var expectedResult = new List<int> { 2, 1, 0, 3, 4 };

            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }

        [TestMethod]
        public void ReversePartTest2()
        {
            var list = new List<int> { 0, 1, 2, 3, 4 };

            var result = list.ReversePart(3, 3);

            var expectedResult = new List<int> { 3, 1, 2, 0, 4 };

            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }

        [TestMethod]
        public void ReversePartTest3()
        {
            var list = new List<int> { 4, 3, 0, 1, 2 };

            var result = list.ReversePart(1, 5);

            var expectedResult = new List<int> { 3, 4, 2, 1, 0 };

            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }
    }
}
