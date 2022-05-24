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
    }
}
