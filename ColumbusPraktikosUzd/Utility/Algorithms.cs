using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusPraktikosUzd
{
    public enum Language
    {
        Lithuanian,
        English
    }

    public class Algorithms
    {
        public static string ReverseStringShort(string text) => string.Concat(text.Reverse());
        public static string ReverseString(string text)
        {
            var length = text.Length;
            var reversed = new char[length];

            for(int i = length - 1; i >= 0; i--)
            {
                reversed[length - i - 1] = text[i];
            }

            return string.Concat(reversed);
        }

        public static int[] RandomisedArray(int length, int min, int max)
        {
            var randomiser = new Random();
            var array = new int[length];
            for(var i = 0; i < length; i++)
            {
                array[i] = randomiser.Next(min, max);
            }
            return array;
        }

        public static (int min, int max) FindMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];
            foreach(var number in array)
            {
                if(number < min)
                {
                    min = number;
                }
                else if(number > max)
                {
                    max = number;
                }
            }
            
            return (min, max);
        }

        public static NumberCounter[] CountOccurences(int[] array)
        {
            var counters = new List<NumberCounter>();
            for(var i = 0; i < array.Length; i++)
            {
                var counter = counters.Find(x => x.Number == array[i]);

                if (counter is null)
                {
                    counters.Add(new NumberCounter(array[i], i));
                } else
                {
                    counter.AddIndex(i);
                }
            }

            return counters.ToArray();
        }

        public static NumberCounterBase[] CountOccurencesShort(int[] array)
        {
            var counters = new List<NumberCounterBase>();
            var unique = array.Distinct();
            foreach(var number in unique)
            {
                var count = array.Count(x => x == number);
                counters.Add(new NumberCounterBase(number, count));
            }

            return counters.ToArray();
        }

        public static NumberCounterBase[] GetReoccuring(NumberCounterBase[] counters)
        {
            return counters.Where(x => x.Count > 1).ToArray();
        }

        public static (int vowels, int consonants) VowelConsonantCounter(Language language, string text)
        {
            int vowels = 0, consonants = 0;
            switch (language)
            {
                case Language.Lithuanian:
                    char[] LithuanianVovels = new char[] { 'a', 'ą', 'e', 'ę', 'ė', 'i', 'į', 'y', 'o', 'u', 'ų', 'ū' };
                    char[] LithuanianConsonants = new char[] { 'b', 'c', 'č', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'š', 't', 'v', 'z', 'ž' };

                    (vowels, consonants) = VowelConsonantCounter(text, LithuanianVovels, LithuanianConsonants);

                    break;

                default:
                    throw new NotImplementedException("Language was not implemented");
            }

            return (vowels, consonants);
        }

        public static (int vowels, int consonants) VowelConsonantCounter(string text, char[] vowels, char[] consonants)
        {
            int vowelCount = 0, consonantCount = 0;

            text = text.ToLower();
            foreach(var letter in text)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
                else if (consonants.Contains(letter))
                {
                    consonantCount++;
                }
            }

            return (vowelCount, consonantCount);
        }
    }
}
