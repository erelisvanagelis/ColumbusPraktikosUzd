using ColumbusPraktikosUzd;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ColumbusPraktikosUzdTest
{
    public class AlgorithmsTests
    {

        [Test]
        public void ReverseString_Programuotojas_sajotoumargorP()
        {
            string input = "Programuotojas";
            string output = "sajotoumargorP";

            Assert.AreEqual(output, Algorithms.ReverseString(input));
        }

        [Test]
        public void ReverseStringShort_Programuotojas_sajotoumargorP()
        {
            string input = "Programuotojas";
            string output = "sajotoumargorP";

            Assert.AreEqual(output, Algorithms.ReverseStringShort(input));
        }

        [Test]
        public void ReverseString_null_NullReferenceException()
        {
            string input = null;
            string output = "sajotoumargorP";

            Assert.Throws<NullReferenceException>(() => Algorithms.ReverseString(input));
        }

        [Test]
        public void RandomisedArray_100()
        {
            var emptyArray = new int[100];

            Assert.AreNotEqual(emptyArray, Algorithms.RandomisedArray(100, 0, 100));
        }

        [Test]
        public void FindMinMax()
        {
            var randomisedArray = Algorithms.RandomisedArray(100, 0, 100);
            (int min, int max) = Algorithms.FindMinMax(randomisedArray);

            Assert.GreaterOrEqual(min, 0);
            Assert.LessOrEqual(max, 100);
            Assert.AreEqual(randomisedArray.Max(), max);
            Assert.AreEqual(randomisedArray.Min(), min);
        }
    }
}