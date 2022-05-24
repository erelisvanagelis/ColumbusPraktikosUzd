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
    }
}
