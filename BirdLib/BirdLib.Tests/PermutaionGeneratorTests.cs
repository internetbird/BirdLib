using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BirdLib.Tests
{
    [TestClass]
    public class PermutaionGeneratorTests
    {
        [TestMethod]
        public void TestGetAllCouples_Length()
        {
            var permutationGenerator = new PermutationGenerator();
            var items = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var allCouples = permutationGenerator.GetAllCouples(items);

            Assert.AreEqual(21, allCouples.Count);
        }

        [TestMethod]
        public void TestGetAllCouples1()
        {
            var permutationGenerator = new PermutationGenerator();
            var items = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var allCouples = permutationGenerator.GetAllCouples(items);

            var couple = allCouples.FirstOrDefault(couple => (couple.Item1 == 4 && couple.Item2 == 7)
            || (couple.Item1 == 7 && couple.Item2 == 4));

            Assert.IsNotNull(couple);
        }
    }
}
