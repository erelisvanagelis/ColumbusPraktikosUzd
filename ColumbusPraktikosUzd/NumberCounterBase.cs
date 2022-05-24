namespace ColumbusPraktikosUzd
{
    public class NumberCounterBase
    {
        protected int number;
        protected int count;

        public int Number { get => number; }
        public int Count { get => count; }

        public NumberCounterBase(int number, int count)
        {
            this.number = number;
            this.count = count;
        }

        public override string ToString()
        {
            return $"{{\n" +
                $"number: {Number}, \n" +
                $"count: {Count}, \n" +
                $"}}";
        }
    }
}