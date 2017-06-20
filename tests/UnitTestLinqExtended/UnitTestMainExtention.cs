using System;
using System.Collections.Generic;
using System.Linq;
using LinqExtended;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLinqExtended
{
    [TestClass]
    public class UnitTestMainExtention
    {
        [TestMethod]
        public void TestFilter()
        {
            Assert.IsTrue((new List<int>() { 1, 2, 5, 9 }).Filter(elem => elem > 4).Count() == 2);
        }

        [TestMethod]
        public void TestContains()
        {
            var superSet = new List<int>() { 1, 2, 5, 9 };
            var subSet = new List<int>() { 1, 2 };
            Assert.IsTrue(superSet.Contains(subSet) && !superSet.Contains(new List<int> { 8, 2, 9 }));
        }
    }
}
