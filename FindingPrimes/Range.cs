namespace FindingPrimes
{
    public class Range
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public bool IsValid()
        {
            return Start <= End;
        }

        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
