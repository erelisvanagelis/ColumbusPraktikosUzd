using ColumbusPraktikosUzd;
using NUnit.Framework;
using System;

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
    }
}