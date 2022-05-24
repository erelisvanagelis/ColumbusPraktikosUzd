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

        [Test]
        public void CountOccurences()
        {
            var randomisedArray = Algorithms.RandomisedArray(100, 0, 50);
            List<NumberCounter> numberCounters = Algorithms.CountOccurences(randomisedArray);

            foreach(NumberCounter counter in numberCounters)
            {
                Console.WriteLine(counter.ToString());
            }

            Assert.LessOrEqual(numberCounters.Count, 50);
        }

        [Test]
        public void CountOccurences_7_8_9()
        {
            var simpleArray = new int[] { 7, 8, 9 };

            List<NumberCounter> numberCounters = Algorithms.CountOccurences(simpleArray);

            Assert.AreEqual(numberCounters.Count, simpleArray.Length);
        }

        [Test]
        public void CountOccurences_7_7_7()
        {
            var simpleArray = new int[] { 7, 7, 7 };

            List<NumberCounter> numberCounters = Algorithms.CountOccurences(simpleArray);

            Assert.AreEqual(numberCounters.Count, 1);
            Assert.AreEqual(numberCounters[0].Number, 7);
            Assert.AreEqual(numberCounters[0].Count, 3);
        }

        [Test]
        public void GetReouccuring()
        {
            var randomisedArray = Algorithms.RandomisedArray(100, 0, 50);
            List<NumberCounter> numberCounters = Algorithms.GetReoccuring(randomisedArray);

            Assert.AreEqual(numberCounters.Find(x => x.Count == 1), null);
        }

        [Test]
        public void CountOccurencesShort()
        {
            var simpleArray = new int[] { 7, 7, 7 };

            List<NumberCounterBase> numberCounters = Algorithms.CountOccurencesShort(simpleArray);

            Console.WriteLine(numberCounters[0].ToString());
            Assert.AreEqual(numberCounters[0].Count, 3);
        }
    }
}