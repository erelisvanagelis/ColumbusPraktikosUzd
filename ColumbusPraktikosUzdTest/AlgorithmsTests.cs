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
            var numberCounters = Algorithms.CountOccurences(randomisedArray);

            foreach(NumberCounter counter in numberCounters)
            {
                Console.WriteLine(counter.ToString());
            }

            Assert.LessOrEqual(numberCounters.Length, 50);
        }

        [Test]
        public void CountOccurences_7_8_9()
        {
            var simpleArray = new int[] { 7, 8, 9 };

            var numberCounters = Algorithms.CountOccurences(simpleArray);

            Assert.AreEqual(3, numberCounters.Length);
        }

        [Test]
        public void CountOccurences_7_7_7()
        {
            var simpleArray = new int[] { 7, 7, 7 };

            var numberCounters = Algorithms.CountOccurences(simpleArray);

            Assert.AreEqual(1, numberCounters.Length);
            Assert.AreEqual(7, numberCounters[0].Number);
            Assert.AreEqual(3, numberCounters[0].Count);
        }

        [Test]
        public void GetReouccuring()
        {
            var randomisedArray = Algorithms.RandomisedArray(100, 0, 50);
            var allCounters = Algorithms.CountOccurences(randomisedArray);
            var reocurringCounters = Algorithms.GetReoccuring(allCounters);

            Assert.Throws<InvalidOperationException>(() => reocurringCounters.First(x => x.Count == 1));
        }

        [Test]
        public void CountOccurencesShort()
        {
            var simpleArray = new int[] { 7, 7, 7 };

            var numberCounters = Algorithms.CountOccurencesShort(simpleArray);

            Console.WriteLine(numberCounters[0].ToString());
            Assert.AreEqual(3, numberCounters[0].Count);
        }

        [Test]
        public void VowelConsonantCounter()
        {
            var text = "Programuotojo ar tiesiog bet kokio IT specialisto profesija taps vis labiau įprasta.";
            (int vowels, int consonants) = Algorithms.VowelConsonantCounter(Language.Lithuanian, text);

            Console.WriteLine(vowels);
            Console.WriteLine(consonants);

            Assert.AreEqual(34, vowels);
            Assert.AreEqual(38, consonants);
        }

        [Test]
        public void VowelConsonantCounter_ltAlphabetVowels_24()
        {
            var text = "Aa Ąa Ee Ęę Ėė Ii Įį Yy Oo Uu Ųų Ūū";
            (int vowels, int consonants) = Algorithms.VowelConsonantCounter(Language.Lithuanian, text);

            Assert.AreEqual(24, vowels);
            Assert.AreEqual(0, consonants);
        }

        [Test]
        public void VowelConsonantCounter_ltAlphabetConsonants_40()
        {
            var text = "Bb Cc Čč Dd Ff Gg Hh Jj Kk Ll Mm Nn Pp Rr Ss Šš Tt Vv Zz Žž";
            (int vowels, int consonants) = Algorithms.VowelConsonantCounter(Language.Lithuanian, text);

            Assert.AreEqual(40, consonants);
            Assert.AreEqual(0, vowels);
        }

        [Test]
        public void VowelConsonantCounter_ltAlphabet_56()
        {
            var text = "Aa Ąa Ee Ęę Ėė Ii Įį Yy Oo Uu Ųų Ūū Bb Cc Čč Dd Ff Gg Hh Jj Kk Ll Mm Nn Pp Rr Ss Šš Tt Vv Zz Žž";
            (int vowels, int consonants) = Algorithms.VowelConsonantCounter(Language.Lithuanian, text);

            Assert.AreEqual(24, vowels);
            Assert.AreEqual(40, consonants);
        }

        [Test]
        public void VowelConsonantCounter_English_NotImplementedException()
        {
            Assert.Throws<NotImplementedException>(() => Algorithms.VowelConsonantCounter(Language.English, "trta"));
        }
    }
}