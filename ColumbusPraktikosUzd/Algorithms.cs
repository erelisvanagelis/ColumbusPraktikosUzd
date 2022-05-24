using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusPraktikosUzd
{
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

        public static List<NumberCounter> CountOccurences(int[] array)
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

            return counters;
        }

        public static List<NumberCounterBase> CountOccurencesShort(int[] array)
        {
            var counters = new List<NumberCounterBase>();
            var unique = array.Distinct();
            foreach(var number in unique)
            {
                var count = array.Count(x => x == number);
                counters.Add(new NumberCounterBase(number, count));
            }

            return counters;
        }

        public static List<NumberCounter> GetReoccuring(int[] array)
        {
            var counters = CountOccurences(array);
            return counters.Where(x => x.Count > 1).ToList();
        }
    }
}
