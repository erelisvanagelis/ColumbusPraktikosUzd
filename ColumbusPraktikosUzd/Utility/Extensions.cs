using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusPraktikosUzd.Utility
{
    public static class Extensions
    {
        public static string ToPrintable(this Array array)
        {
            string text = "{";
            foreach(var item in array)
            {
                text += $" {item.ToString()},";
            }
            
            return text;
        }
    }
}
