using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.Tests
{
    [TestClass]
    public class ListCrowTests
    {

        [TestMethod]
        public void IsNonDecreasingSeriesTest1()
        {
            var series = new int[] { 1, 1, 1, 1 };
            Assert.IsTrue(ListCrow.IsNonDecreasingSeries(series));
        }


        [TestMethod]
        public void IsNonDecreasingSeriesTest2()
        {
            var series = new int[] { 1, 1, 1, 0 };
            Assert.IsFalse(ListCrow.IsNonDecreasingSeries(series));
        }


        [TestMethod]
        public void IsNonDecreasingSeriesTest3()
        {
            var series = new int[] { 1, 2, 4, 8 };
            Assert.IsTrue(ListCrow.IsNonDecreasingSeries(series));
        }

        [TestMethod]
        public void IsNonDecreasingSeriesTest4()
        {
            var series = new int[] { 1, 2, 1, 1 };
            Assert.IsFalse(ListCrow.IsNonDecreasingSeries(series));
        }
    }
}
