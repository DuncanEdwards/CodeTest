using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;

namespace IDL.Question1and2.Sorter.Test
{
    [TestClass]
    public class SorterTests
    {

        private List<string> GetStringDataList()
        {
            return new List<string>()
            {
                "Andrew",
                "Duncan",
                "Samuel",
                "Andrea",
                "Cooper",
                "Andy",
                "Duncan",
            };
        }

        private List<int> GetIntDataList()
        {
            return new List<int>()
            {
                4,
                7,
                3,
                3,
                -4,
                0,
                8
            };
        }

        [TestMethod]
        public void TestIntSortAsc()
        {
            var sorter = new Sorter();
            var results = sorter.BubbleSort<int>(
                GetIntDataList(),
                new Comparers.IntComparer(ListSortDirection.Ascending));

            Assert.AreEqual(7, results.Count);
            Assert.AreEqual(-4, results[0]);
            Assert.AreEqual(0, results[1]);
            Assert.AreEqual(3, results[2]);
            Assert.AreEqual(3, results[3]);
            Assert.AreEqual(4, results[4]);
            Assert.AreEqual(7, results[5]);
            Assert.AreEqual(8, results[6]);

        }

        [TestMethod]
        public void TestIntSortDesc()
        {
            var sorter = new Sorter();
            var results = sorter.BubbleSort<int>(
                GetIntDataList(),
                new Comparers.IntComparer(ListSortDirection.Descending));

            Assert.AreEqual(7, results.Count);
            Assert.AreEqual(-4, results[6]);
            Assert.AreEqual(0, results[5]);
            Assert.AreEqual(3, results[4]);
            Assert.AreEqual(3, results[3]);
            Assert.AreEqual(4, results[2]);
            Assert.AreEqual(7, results[1]);
            Assert.AreEqual(8, results[0]);

        }

        [TestMethod]
        public void TestStringSortAsc()
        {
            var sorter = new Sorter();
            var results = sorter.BubbleSort<string>(
                GetStringDataList(), 
                new Comparers.StringComparer(ListSortDirection.Ascending));

            Assert.AreEqual(7, results.Count);
            Assert.AreEqual("Andrea", results[0]);
            Assert.AreEqual("Andrew", results[1]);
            Assert.AreEqual("Andy", results[2]);
            Assert.AreEqual("Cooper", results[3]);
            Assert.AreEqual("Duncan", results[4]);
            Assert.AreEqual("Duncan", results[5]);
            Assert.AreEqual("Samuel", results[6]);

        }

        [TestMethod]
        public void TestStringSortDesc()
        {
            var sorter = new Sorter();
            var results = sorter.BubbleSort<string>(
                GetStringDataList(),
                new Comparers.StringComparer(ListSortDirection.Descending));

            Assert.AreEqual(7, results.Count);
            Assert.AreEqual("Andrea", results[6]);
            Assert.AreEqual("Andrew", results[5]);
            Assert.AreEqual("Andy", results[4]);
            Assert.AreEqual("Cooper", results[3]);
            Assert.AreEqual("Duncan", results[2]);
            Assert.AreEqual("Duncan", results[1]);
            Assert.AreEqual("Samuel", results[0]);

        }

        [TestMethod]
        public void TestWithOneValue()
        {
            var sorter = new Sorter();
            var results = sorter.BubbleSort<string>(
                new List<string>() { "test" },
                new Comparers.StringComparer(ListSortDirection.Ascending));

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("test", results[0]);

        }
    }
}
