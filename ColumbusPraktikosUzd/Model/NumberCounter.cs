using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusPraktikosUzd
{
    public class NumberCounter : NumberCounterBase
    {
        List<int> indexes;

        public List<int> Indexes { get => indexes;}

        public NumberCounter(int number, int index) : base(number, 0)
        {
            this.number = number;
            this.indexes = new List<int>();
            AddIndex(index);
        }

        public NumberCounter(int number, int[] indexes) : base(number, 0)
        {
            this.number = number;
            this.indexes = new List<int>();
            Indexes.AddRange(indexes);
        }

        public void AddIndex(int index)
        {
            indexes.Add(index);
            count++;
        }

        public override string ToString()
        {
            var text = $"{{ {string.Join(", ", indexes)} }}";
            return $"{{\n" +
                $"number: {Number}, \n" +
                $"count: {Count}, \n" +
                $"indexes: {text}, \n" +
                $"}}";
        }
    }
}
